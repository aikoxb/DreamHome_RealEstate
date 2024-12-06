-- Task 2-1

CREATE OR REPLACE FUNCTION get_branch_address(p_branchno IN VARCHAR2)
RETURN VARCHAR2 IS
    v_address VARCHAR2(100);
BEGIN
    SELECT street || ', ' || city || ', ' || postcode
    INTO v_address
    FROM dh_branch
    WHERE branchno = p_branchno;

    RETURN v_address;
EXCEPTION
    WHEN NO_DATA_FOUND THEN
        RETURN 'Branch not found';
END;