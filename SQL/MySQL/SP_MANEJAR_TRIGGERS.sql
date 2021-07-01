DELIMITER $$

CREATE PROCEDURE AUDITORIA.sp_MANEJAR_TRIGGER
(
IN param_FLAG INT
)
BEGIN

	IF param_FLAG=0 THEN

            SET @disable_triggers=0;
		    

		ELSE
        
			 SET @disable_triggers=NULL;

		
			
	END IF;
END$$