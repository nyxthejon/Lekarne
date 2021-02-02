# Lekarne

Funkcije
Izpis krajev

-- FUNCTION: public.krajizpis()

-- DROP FUNCTION public.krajizpis();

CREATE OR REPLACE FUNCTION public.krajizpis(
	)
    RETURNS TABLE(kraj character varying, pos character varying) 
    LANGUAGE 'plpgsql'

    COST 100
    VOLATILE 
    ROWS 1000
AS $BODY$
BEGIN
RETURN QUERY
SELECT ime_k,posta FROM kraji;
END;
$BODY$;

ALTER FUNCTION public.krajizpis()
    OWNER TO smqoixml;


Izpis vseh podatkov o lekarni

-- FUNCTION: public.izplekarne(integer)

-- DROP FUNCTION public.izplekarne(integer);

CREATE OR REPLACE FUNCTION public.izplekarne(
	id integer)
    RETURNS TABLE(ime character varying, tel character varying, delovnicas character varying, naslov character varying, kraj character varying, pot character varying, op text, st_delavcev integer) 
    LANGUAGE 'plpgsql'

    COST 100
    VOLATILE 
    ROWS 1000
AS $BODY$
BEGIN
RETURN QUERY 
SELECT l.ime_l,l.telefon_l,l.delovnicas,l.naslov,k.ime_k,s.url_slike,s.opis,l.st_delavcev FROM kraji k INNER JOIN lekarne l ON l.kraj_id = k.id_k INNER JOIN
slike s ON s.lekarna_id = l.id_l WHERE l.id_l = id;
END;
$BODY$;

ALTER FUNCTION public.izplekarne(integer)
    OWNER TO smqoixml;


Registracija

-- FUNCTION: public.registracija(character varying, character varying, character varying, character varying, character varying)

-- DROP FUNCTION public.registracija(character varying, character varying, character varying, character varying, character varying);

CREATE OR REPLACE FUNCTION public.registracija(
	mail character varying,
	geslo character varying,
	ime character varying,
	tel character varying,
	kraj character varying)
    RETURNS boolean
    LANGUAGE 'plpgsql'

    COST 100
    VOLATILE 
AS $BODY$
DECLARE
mejl varchar;
prev BOOL;
kid int;
BEGIN
prev := true;
FOR mejl IN SELECT email FROM uporabniki 
LOOP
IF(mail = mejl) THEN
prev := false;
END IF;
END LOOP;
IF(prev != false) THEN
SELECT INTO kid id_k FROM kraji WHERE ime_k = kraj; 
INSERT INTO uporabniki(email,pass,telefon_u,kraj_id,ime_u) 
VALUES(mail,geslo,tel,kid,ime);
END IF;
RETURN prev;
END;
$BODY$;

ALTER FUNCTION public.registracija(character varying, character varying, character varying, character varying, character varying)
    OWNER TO smqoixml;






Izpis vseh lekarn
-- FUNCTION: public.kratizpislekarn()

-- DROP FUNCTION public.kratizpislekarn();

CREATE OR REPLACE FUNCTION public.kratizpislekarn(
	)
    RETURNS TABLE(id integer, ime character varying, tel character varying, dcas character varying, naslov character varying, imek character varying, std integer) 
    LANGUAGE 'plpgsql'

    COST 100
    VOLATILE 
    ROWS 1000
AS $BODY$
BEGIN 
RETURN QUERY 
SELECT l.id_l,l.ime_l,l.telefon_l,l.delovnicas,l.naslov,k.ime_k,l.st_delavcev FROM kraji k INNER JOIN lekarne l ON l.kraj_id = k.id_k;
END;
$BODY$;

ALTER FUNCTION public.kratizpislekarn()
    OWNER TO smqoixml;


Vnos lekarne

-- FUNCTION: public.vnoslekarne(character varying, character varying, character varying, character varying, character varying, character varying, text)

-- DROP FUNCTION public.vnoslekarne(character varying, character varying, character varying, character varying, character varying, character varying, text);

CREATE OR REPLACE FUNCTION public.vnoslekarne(
	ime character varying,
	tel character varying,
	d_cas character varying,
	nas character varying,
	kraj character varying,
	pot character varying,
	op text)
    RETURNS boolean
    LANGUAGE 'plpgsql'

    COST 100
    VOLATILE 
AS $BODY$
DECLARE
kid INT;
ok BOOL;
lid INT;
lrow lekarne%rowtype;
BEGIN 
ok := true;
SELECT INTO kid id_k FROM kraji WHERE ime_k = kraj;

FOR lrow IN SELECT * FROM lekarne
LOOP 
IF (lrow.ime_l = ime AND lrow.naslov = nas) THEN 
ok := FALSE;
END IF;
END LOOP;

IF(ok = true) THEN
INSERT INTO lekarne(ime_l,telefon_l,delovnicas,naslov,kraj_id)
VALUES(ime,tel,d_cas,nas,kid);
SELECT INTO lid id_l FROM lekarne WHERE ime_l = ime AND naslov = nas;
INSERT INTO slike(url_slike,opis,lekarna_id)
VALUES(pot,op,lid);
END IF;

RETURN ok;
END;
$BODY$;

ALTER FUNCTION public.vnoslekarne(character varying, character varying, character varying, character varying, character varying, character varying, text)
    OWNER TO smqoixml;


Prijava

-- FUNCTION: public.pri(character varying, character varying)

-- DROP FUNCTION public.pri(character varying, character varying);

CREATE OR REPLACE FUNCTION public.pri(
	mejl character varying,
	passw character varying)
    RETURNS boolean
    LANGUAGE 'plpgsql'

    COST 100
    VOLATILE 
AS $BODY$
DECLARE
prev BOOL;
uid int;
em varchar;
pe varchar;
BEGIN
prev := false;
FOR uid IN SELECT id_u FROM uporabniki 
LOOP
SELECT INTO em email FROM uporabniki WHERE id_u = uid;
SELECT INTO pe pass FROM uporabniki WHERE id_u = uid;
IF(mejl = em AND passw = pe) THEN
prev := true;
END IF;
END LOOP;

RETURN prev;
END;
$BODY$;

ALTER FUNCTION public.pri(character varying, character varying)
    OWNER TO smqoixml;


Update lekarne

-- FUNCTION: public.updatelekarne(integer, character varying, character varying, character varying, character varying, character varying, character varying, text)

-- DROP FUNCTION public.updatelekarne(integer, character varying, character varying, character varying, character varying, character varying, character varying, text);

CREATE OR REPLACE FUNCTION public.updatelekarne(
	id integer,
	lime character varying,
	tel character varying,
	dcas character varying,
	nas character varying,
	kraj character varying,
	pot character varying,
	op text)
    RETURNS void
    LANGUAGE 'plpgsql'

    COST 100
    VOLATILE 
AS $BODY$
DECLARE
kid INT;
BEGIN
SELECT INTO kid id_k FROM kraji WHERE ime_K = kraj;
UPDATE lekarne
SET ime_l = lime,telefon_l = tel,delovnicas = dcas,naslov = nas,kraj_id = kid
WHERE id_l = id;



UPDATE slike
 
SET url_slike = pot,opis = op
WHERE lekarna_id = id;

END;
$BODY$;

ALTER FUNCTION public.updatelekarne(integer, character varying, character varying, character varying, character varying, character varying, character varying, text)
    OWNER TO smqoixml;


Delete lekarne

-- FUNCTION: public.deletelekarno(integer)

-- DROP FUNCTION public.deletelekarno(integer);

CREATE OR REPLACE FUNCTION public.deletelekarno(
	idl integer)
    RETURNS void
    LANGUAGE 'plpgsql'

    COST 100
    VOLATILE 
AS $BODY$
BEGIN
DELETE FROM slike 
WHERE lekarna_id = idl;

DELETE FROM lekarne 
WHERE id_l = idl;

END;
$BODY$;

ALTER FUNCTION public.deletelekarno(integer)
    OWNER TO smqoixml;


Preverjanje maila

-- FUNCTION: public.prevmail(character varying)

-- DROP FUNCTION public.prevmail(character varying);

CREATE OR REPLACE FUNCTION public.prevmail(
	mejl character varying)
    RETURNS boolean
    LANGUAGE 'plpgsql'

    COST 100
    VOLATILE 
AS $BODY$
DECLARE m VARCHAR;
ok BOOL;
BEGIN
ok := FALSE;
FOR m IN SELECT email FROM uporabniki
LOOP
IF(m = mejl) THEN
ok := TRUE;
END IF;
END LOOP;
RETURN ok;
END;
$BODY$;

ALTER FUNCTION public.prevmail(character varying)
    OWNER TO smqoixml;

Zamenjaj geslo 

-- FUNCTION: public.zamgeslo(character varying, character varying)

-- DROP FUNCTION public.zamgeslo(character varying, character varying);

CREATE OR REPLACE FUNCTION public.zamgeslo(
	mejl character varying,
	gesl character varying)
    RETURNS void
    LANGUAGE 'plpgsql'

    COST 100
    VOLATILE 
AS $BODY$
BEGIN
UPDATE uporabniki
SET pass = gesl 
WHERE email = mejl;
END;
$BODY$;

ALTER FUNCTION public.zamgeslo(character varying, character varying)
    OWNER TO smqoixml;

Delete kraj

-- FUNCTION: public.delkraj(character varying, character varying)

-- DROP FUNCTION public.delkraj(character varying, character varying);

CREATE OR REPLACE FUNCTION public.delkraj(
	imek character varying,
	pos character varying)
    RETURNS void
    LANGUAGE 'plpgsql'

    COST 100
    VOLATILE 
AS $BODY$
BEGIN
DELETE FROM kraji
WHERE ime_k = imek AND posta = pos;
END;
$BODY$;

ALTER FUNCTION public.delkraj(character varying, character varying)
    OWNER TO smqoixml;


Update kraj

-- FUNCTION: public.updatekraj(character varying, character varying, character varying, character varying)

-- DROP FUNCTION public.updatekraj(character varying, character varying, character varying, character varying);

CREATE OR REPLACE FUNCTION public.updatekraj(
	imek character varying,
	pos character varying,
	simek character varying,
	spos character varying)
    RETURNS void
    LANGUAGE 'plpgsql'

    COST 100
    VOLATILE 
AS $BODY$
DECLARE imkr VARCHAR;
BEGIN
UPDATE kraji
SET ime_k = imek, posta = pos 
WHERE ime_k = simek AND posta = spos;
END;
$BODY$;

ALTER FUNCTION public.updatekraj(character varying, character varying, character varying, character varying)
    OWNER TO smqoixml;

Insert kraj

-- FUNCTION: public.insertkraj(character varying, character varying)

-- DROP FUNCTION public.insertkraj(character varying, character varying);

CREATE OR REPLACE FUNCTION public.insertkraj(
	imek character varying,
	pos character varying)
    RETURNS boolean
    LANGUAGE 'plpgsql'

    COST 100
    VOLATILE 
AS $BODY$
DECLARE imkr VARCHAR;
ok BOOL;
BEGIN
ok := TRUE;
FOR imkr IN SELECT ime_k FROM kraji 
LOOP 
IF(imkr = imek) THEN
ok := FALSE;
END IF;
END LOOP;
IF(ok = TRUE) THEN
INSERT INTO kraji(ime_k,posta)
VALUES (imek,pos);
END IF;
RETURN ok;
END;
$BODY$;

ALTER FUNCTION public.insertkraj(character varying, character varying)
    OWNER TO smqoixml;

Id uporabnika

-- FUNCTION: public.getiduporabnika(character varying, character varying)

-- DROP FUNCTION public.getiduporabnika(character varying, character varying);

CREATE OR REPLACE FUNCTION public.getiduporabnika(
	em character varying,
	pas character varying)
    RETURNS integer
    LANGUAGE 'plpgsql'

    COST 100
    VOLATILE 
AS $BODY$
DECLARE
ajdi INTEGER;
BEGIN
SELECT INTO ajdi id_u FROM uporabniki WHERE email = em AND pass = pas;
RETURN ajdi;
END;
$BODY$;

ALTER FUNCTION public.getiduporabnika(character varying, character varying)
    OWNER TO smqoixml;

Update user

-- FUNCTION: public.updateuser(character varying, character varying, character varying, character varying, character varying, integer)

-- DROP FUNCTION public.updateuser(character varying, character varying, character varying, character varying, character varying, integer);

CREATE OR REPLACE FUNCTION public.updateuser(
	em character varying,
	ps character varying,
	tel character varying,
	kr character varying,
	im character varying,
	ajdi integer)
    RETURNS boolean
    LANGUAGE 'plpgsql'

    COST 100
    VOLATILE 
AS $BODY$
DECLARE
ok bool;
idu INT;
emi VARCHAR;
kid INT;
BEGIN
ok := TRUE;
FOR emi IN SELECT email FROM uporabniki 
LOOP
SELECT INTO idu id_u FROM uporabniki WHERE email = emi;
IF emi = em and ajdi != idu THEN
ok := FALSE;
END IF;
END LOOP;

IF ok = TRUE THEN
SELECT INTO kid id_k FROM kraji WHERE ime_k = kr;
UPDATE uporabniki 
SET email = em, pass = ps, telefon_u = tel, kraj_id = kid,ime_u = im
WHERE id_u = ajdi;
END IF;
RETURN ok;
END;
$BODY$;

ALTER FUNCTION public.updateuser(character varying, character varying, character varying, character varying, character varying, integer)
    OWNER TO smqoixml;

Delete user 

-- FUNCTION: public.deluser(integer)

-- DROP FUNCTION public.deluser(integer);

CREATE OR REPLACE FUNCTION public.deluser(
	ajdi integer)
    RETURNS void
    LANGUAGE 'plpgsql'

    COST 100
    VOLATILE 
AS $BODY$
BEGIN
DELETE FROM uporabniki 
WHERE id_u = ajdi;
END;
$BODY$;

ALTER FUNCTION public.deluser(integer)
    OWNER TO smqoixml;


Stevilo lekarn v kraju

-- FUNCTION: public.stlek_pokraju(character varying, character varying)

-- DROP FUNCTION public.stlek_pokraju(character varying, character varying);

CREATE OR REPLACE FUNCTION public.stlek_pokraju(
	imek character varying,
	posk character varying)
    RETURNS integer
    LANGUAGE 'plpgsql'

    COST 100
    VOLATILE 
AS $BODY$
DECLARE 
stlek INT;
BEGIN
SELECT INTO stlek stevilo_lekarn FROM kraji WHERE ime_k = imek AND posta = posk;
IF(stlek IS NULL) THEN
stlek := 0;
END IF;
RETURN stlek;
END;
$BODY$;

ALTER FUNCTION public.stlek_pokraju(character varying, character varying)
    OWNER TO smqoixml;

Sprememba v delavca

-- FUNCTION: public.sprememba_delavca(integer, character varying, character varying)

-- DROP FUNCTION public.sprememba_delavca(integer, character varying, character varying);

CREATE OR REPLACE FUNCTION public.sprememba_delavca(
	id integer,
	imelek character varying,
	naslek character varying)
    RETURNS void
    LANGUAGE 'plpgsql'

    COST 100
    VOLATILE 
AS $BODY$
DECLARE
lid INT;
BEGIN
SELECT INTO lid id_l FROM lekarne WHERE imelek = ime_l AND naslek = naslov;
UPDATE uporabniki
SET prev_zaposlen = TRUE, delavec_lek_id = lid
WHERE id_u = id;
END;
$BODY$;

ALTER FUNCTION public.sprememba_delavca(integer, character varying, character varying)
    OWNER TO smqoixml;

Odstranitev Delavca

-- FUNCTION: public.odstranidelavca(integer)

-- DROP FUNCTION public.odstranidelavca(integer);

CREATE OR REPLACE FUNCTION public.odstranidelavca(
	id integer)
    RETURNS void
    LANGUAGE 'plpgsql'

    COST 100
    VOLATILE 
AS $BODY$
BEGIN
UPDATE uporabniki 
SET prev_zaposlen = FALSE, delavec_lek_id = 0
WHERE id_u = id;
END;
$BODY$;

ALTER FUNCTION public.odstranidelavca(integer)
    OWNER TO smqoixml;

Izpis uporabnikov

-- FUNCTION: public.izpisuporabnika(integer)

-- DROP FUNCTION public.izpisuporabnika(integer);

CREATE OR REPLACE FUNCTION public.izpisuporabnika(
	id integer)
    RETURNS TABLE(email character varying, pass character varying, telefon_u character varying, kraj character varying, ime character varying, idlek int) 
    LANGUAGE 'plpgsql'

    COST 100
    VOLATILE 
    ROWS 1000
AS $BODY$
BEGIN 
RETURN QUERY 
SELECT u.email,u.pass,u.telefon_u,k.ime_k,u.ime_u,u.delavec_lek_id FROM kraji k INNER JOIN uporabniki u ON u.kraj_id = k.id_k WHERE u.id_u = id;
END;
$BODY$;

ALTER FUNCTION public.izpisuporabnika(integer)
    OWNER TO smqoixml;

Izpis delavcev

-- FUNCTION: public.delavciizpis(integer)

-- DROP FUNCTION public.delavciizpis(integer);

CREATE OR REPLACE FUNCTION public.delavciizpis(
	ajdilek integer)
    RETURNS TABLE(ime character varying, telefon character varying, kraj character varying, email character varying) 
    LANGUAGE 'plpgsql'

    COST 100
    VOLATILE 
    ROWS 1000
AS $BODY$
BEGIN
RETURN QUERY
SELECT u.ime_u, u.telefon_u,k.ime_k,u.email FROM uporabniki u INNER JOIN kraji k ON k.id_k = u.kraj_id WHERE u.prev_zaposlen = TRUE AND u.delavec_lek_id = ajdilek;
END
$BODY$;

ALTER FUNCTION public.delavciizpis(integer)
    OWNER TO smqoixml;


Triggerji

Arhiviranje Trigger

-- Trigger: arhiviraj

-- DROP TRIGGER arhiviraj ON public.lekarne;

CREATE TRIGGER arhiviraj
    AFTER INSERT
    ON public.lekarne
    FOR EACH ROW
    EXECUTE PROCEDURE public.arhiv();


-- FUNCTION: public.arhiv()

-- DROP FUNCTION public.arhiv();

CREATE FUNCTION public.arhiv()
    RETURNS trigger
    LANGUAGE 'plpgsql'
    COST 100
    VOLATILE NOT LEAKPROOF
AS $BODY$
BEGIN
INSERT INTO arhiv(a_ime_l,a_telefon,a_delovnicas,a_naslov,a_kraj_id)
VALUES (NEW.ime_l,NEW.telefon_l,NEW.delovnicas,NEW.naslov,NEW.kraj_id);
RETURN NULL;
END;
$BODY$;

ALTER FUNCTION public.arhiv()
    OWNER TO smqoixml;


Število Lekarn Trigger


-- Trigger: st_lekarn

-- DROP TRIGGER st_lekarn ON public.lekarne;

CREATE TRIGGER st_lekarn
    AFTER INSERT OR DELETE OR UPDATE 
    ON public.lekarne
    FOR EACH ROW
    EXECUTE PROCEDURE public.stevilo_lekarn();








-- FUNCTION: public.stevilo_lekarn()

-- DROP FUNCTION public.stevilo_lekarn();

CREATE FUNCTION public.stevilo_lekarn()
    RETURNS trigger
    LANGUAGE 'plpgsql'
    COST 100
    VOLATILE NOT LEAKPROOF
AS $BODY$
DECLARE 
	id_kr INT;
    id_lek INT;
    st INT;
    BEGIN
        FOR id_kr IN SELECT id_k FROM kraji
        LOOP
            st := 0;
            FOR id_lek IN SELECT id_l FROM lekarne
            LOOP
                IF((SELECT kraj_id FROM lekarne WHERE id_l =id_lek AND kraj_id = id_kr) IS NOT NULL) THEN
                    st := st + 1;
                END IF;
            END LOOP;
            UPDATE kraji
            SET stevilo_lekarn  = st
            WHERE id_k = id_kr;
        END LOOP;
    RETURN NULL;
    END;
$BODY$;

ALTER FUNCTION public.stevilo_lekarn()
    OWNER TO smqoixml;

Število Delavcev Trigger

-- Trigger: stetje_delavcev

-- DROP TRIGGER stetje_delavcev ON public.uporabniki;

CREATE TRIGGER stetje_delavcev
    AFTER INSERT OR DELETE OR UPDATE 
    ON public.uporabniki
    FOR EACH ROW
    EXECUTE PROCEDURE public.st_delavcev();











-- FUNCTION: public.st_delavcev()

-- DROP FUNCTION public.st_delavcev();

CREATE FUNCTION public.st_delavcev()
    RETURNS trigger
    LANGUAGE 'plpgsql'
    COST 100
    VOLATILE NOT LEAKPROOF
AS $BODY$
DECLARE 
    id_lek int;
    id_upo int;
    st int;
    BEGIN
        FOR id_lek IN SELECT id_l FROM lekarne
        LOOP
            st := 0;
            FOR id_upo IN SELECT id_u FROM uporabniki
            LOOP
                IF((SELECT delavec_lek_id FROM uporabniki WHERE id_u = id_upo AND delavec_lek_id = id_lek) IS NOT NULL) THEN
                    st := st + 1;
                END IF;
            END LOOP;
            UPDATE Lekarne
            SET st_delavcev  = st
            WHERE id_l = id_lek;
        END LOOP;
    RETURN NULL;
    END;
$BODY$;

ALTER FUNCTION public.st_delavcev()
    OWNER TO smqoixml;
