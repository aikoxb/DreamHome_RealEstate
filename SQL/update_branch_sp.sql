CREATE OR REPLACE PROCEDURE update_branch_sp (
    p_branchno IN dh_branch.branchno%TYPE,
    p_street IN dh_branch.street%TYPE,
    p_city IN dh_branch.city%TYPE,
    p_postcode IN dh_branch.postcode%TYPE
)
AS
BEGIN
    UPDATE dh_branch
    SET street = p_street,
        city = p_city,
        postcode = p_postcode
    WHERE branchno = p_branchno;

    COMMIT;
END;

select * from dh_branch