-- Task 1-1

CREATE OR REPLACE PROCEDURE staff_hire_sp(
    p_staffno IN VARCHAR2,
    p_fname IN VARCHAR2,
    p_lname IN VARCHAR2,
    p_position IN VARCHAR2,
    p_sex IN VARCHAR2,
    p_dob IN DATE,
    p_salary IN NUMBER,
    p_branchno IN VARCHAR2,
    p_telephone IN VARCHAR2,
    p_mobile IN VARCHAR2,
    p_email IN VARCHAR2
)
AS
BEGIN
    INSERT INTO dh_staff (
        staffno, fname, lname, position, sex, dob, salary, branchno, telephone, mobile, email
    )
    VALUES (
        p_staffno, p_fname, p_lname, p_position, p_sex, p_dob, p_salary, p_branchno, p_telephone, p_mobile, p_email
    );
    COMMIT;
END;