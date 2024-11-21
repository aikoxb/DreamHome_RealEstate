--Task1-1
CREATE OR REPLACE PROCEDURE staff_hire_sp
    (--accepts 9 parameters 
    )
AS
BEGIN
    INSERT INTO dh_staff --( col1, col2, col3, col9   ) 
        VALUES --(p_staffno, p_first_name, p_last_name..) 

   COMMIT;
END;
