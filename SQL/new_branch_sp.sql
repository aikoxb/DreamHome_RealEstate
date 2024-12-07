-- Task 2-3
CREATE or REPLACE PROCEDURE new_branch_sp
    (
    p_branchno IN dh_branch.branchno%TYPE, 
    p_street IN dh_branch.street%TYPE, 
    p_city IN dh_branch.city%TYPE, 
    p_postcode IN dh_branch.postcode%TYPE
    )
IS
BEGIN
    INSERT INTO dh_branch (branchno, street, city, postcode)
        VALUES (p_branchno, p_street, p_city, p_postcode);
        
COMMIT;
END;