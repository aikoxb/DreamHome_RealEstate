CREATE OR REPLACE PROCEDURE update_staff_sp (
    p_staffno IN dh_staff.staffno%TYPE,
    p_salary IN dh_staff.salary%TYPE,
    p_telephone IN dh_staff.telephone%TYPE,
    p_email IN dh_staff.email%TYPE
)
AS
BEGIN
    UPDATE dh_staff
    SET salary = p_salary,
        telephone = p_telephone,
        email = p_email
    WHERE staffno = p_staffno;

    COMMIT;
END;