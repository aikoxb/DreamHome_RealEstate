--Task 3-1
CREATE OR REPLACE PROCEDURE client_register_sp 
    (
    p_clientno IN dh_client.clientno%TYPE,
    p_first_name IN dh_client.fname%TYPE,
    p_last_name IN dh_client.lname%TYPE,
    p_telephone IN dh_client.telno%TYPE,
    p_street IN dh_client.street%TYPE,
    p_city IN dh_client.city%TYPE,
    p_email IN dh_client.email%TYPE,
    p_preference_type IN dh_client.preftype%TYPE,
    p_max_rent IN dh_client.maxrent%TYPE
    )
AS
BEGIN
    INSERT INTO dh_client (clientno, fname, lname, telno, street, city, email, preftype, maxrent) 
        VALUES (p_clientno, p_first_name, p_last_name, p_telephone, p_street, p_city, p_email, p_preference_type, p_max_rent);

    COMMIT;
END;