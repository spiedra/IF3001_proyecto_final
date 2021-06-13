DELIMITER $$

CREATE PROCEDURE AUDITORIA.sp_MANEJAR_INCREMENTO
(
IN param_MODO INT
)
BEGIN

	IF param_MODO=0 THEN

            ALTER TABLE ESTUDIANTE.tb_ESTUDIANTE MODIFY COLUMN ID_ESTUDIANTE INT NOT NULL;
			ALTER TABLE ESTUDIANTE.tb_DIRECCION MODIFY COLUMN ID_DIRECCION INT NOT NULL  ;
			ALTER TABLE ESTUDIANTE.tb_TELEFONO MODIFY COLUMN ID_TELEFONO INT  NOT NULL;
		    

		ELSE IF param_MODO=1 THEN
        
			ALTER TABLE ESTUDIANTE.tb_ESTUDIANTE MODIFY COLUMN ID_ESTUDIANTE INT NOT NULL AUTO_INCREMENT;
			ALTER TABLE ESTUDIANTE.tb_DIRECCION MODIFY COLUMN ID_DIRECCION INT NOT NULL AUTO_INCREMENT;
			ALTER TABLE ESTUDIANTE.tb_TELEFONO MODIFY COLUMN ID_TELEFONO INT NOT NULL AUTO_INCREMENT;

			
		END IF;
			
	END IF;
END$$