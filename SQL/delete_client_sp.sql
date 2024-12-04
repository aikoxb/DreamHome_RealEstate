--Task 3-2
CREATE OR REPLACE PROCEDURE delete_client_sp
    (p_clientno IN dh_client.clientno%TYPE)
AS
BEGIN
    DELETE FROM dh_client WHERE clientno = p_clientno;

    COMMIT;
END;