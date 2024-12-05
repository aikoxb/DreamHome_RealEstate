CREATE OR REPLACE FUNCTION get_branch_address(p_branchno IN VARCHAR)
RETURN VARCHAR IS
    v_address VARCHAR(100);
BEGIN
    SELECT street || ', ' || city
    INTO v_address
    FROM dh_branch
    WHERE branchno = p_branchno;

    RETURN v_address;
EXCEPTION
    WHEN NO_DATA_FOUND THEN
        RETURN 'Branch not found';
END;