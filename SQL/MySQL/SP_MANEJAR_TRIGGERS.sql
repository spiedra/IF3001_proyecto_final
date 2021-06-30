DELIMITER $$


CREATE PROCEDURE AUDITORIA.sp_manejar_triggers
(
IN param_BANDERA INT
)
BEGIN

	IF (param_BANDERA=0) THEN
    
		 ALTER TRIGGER ESTUDIANTE.tg_DIRECCION_UPDATE ENABLE 
         ALTER TRIGGER ESTUDIANTE.tg_DIRECCION_DELETE  ENABLE    
         ALTER TRIGGER  ESTUDIANTE.tg_DIRECCION_INSERT  ENABLE   
          ALTER TRIGGER ESTUDIANTE.tg_ESTUDIANTE_UPDATE  ENABLE   
          ALTER TRIGGER  ESTUDIANTE.tg_ESTUDIANTE_DELETE  ENABLE  
          ALTER TRIGGER ESTUDIANTE.tg_ESTUDIANTE_INSERT  ENABLE 
          ALTER TRIGGER ESTUDIANTE.tg_ESTUDIANTE_BECA_UPDATE  ENABLE  
            ALTER TRIGGER ESTUDIANTE.tg_ESTUDIANTE_BECA_DELETE  ENABLE 
            ALTER TRIGGER ESTUDIANTE.tg_ESTUDIANTE_BECA_INSERT ENABLE 
           ALTER TRIGGER ESTUDIANTE.tg_ESTUDIANTE_CARRERA_UPDATE ENABLE
         ALTER TRIGGER  ESTUDIANTE.tg_ESTUDIANTE_CARRERA_DELETE ENABLE
          ALTER TRIGGER ESTUDIANTE.tg_ESTUDIANTE_CARRERA_INSERT ENABLE
          ALTER TRIGGER ESTUDIANTE.tg_ESTUDIANTE_CURSO_UPDATE ENABLE
          ALTER TRIGGER ESTUDIANTE.tg_ESTUDIANTE_CURSO_DELETE ENABLE
          ALTER TRIGGER ESTUDIANTE.tg_ESTUDIANTE_CURSO_INSERT ENABLE
          ALTER TRIGGER ESTUDIANTE.tg_ESTUDIANTE_SEDE_UPDATE ENABLE
         ALTER TRIGGER ESTUDIANTE.tg_ESTUDIANTE_SEDE_UPDATE ENABLE
           ALTER TRIGGER ESTUDIANTE.tg_ESTUDIANTE_SEDE_INSERT ENABLE
          ALTER TRIGGER ESTUDIANTE.tg_ESTUDIANTE_TELEFONO_UPDATE ENABLE
         ALTER TRIGGER ESTUDIANTE.tg_ESTUDIANTE_TELEFONO_DELETE ENABLE
         ALTER TRIGGER ESTUDIANTE.tg_ESTUDIANTE_TELEFONO_INSERT ENABLE
         ALTER TRIGGER ESTUDIANTE.tg_TELEFONO_UPDATE ENABLE
        ALTER TRIGGER ESTUDIANTE.tg_TELEFONO_DELETE ENABLE
        ALTER TRIGGER ESTUDIANTE.tg_TELEFONO_INSERT ENABLE
		    

		ELSEIF param_MODO=1 THEN
        
		 ALTER TRIGGER ESTUDIANTE.tg_DIRECCION_UPDATE DISABLE
         ALTER TRIGGER ESTUDIANTE.tg_DIRECCION_DELETE  DISABLE
         ALTER TRIGGER  ESTUDIANTE.tg_DIRECCION_INSERT  DISABLE
          ALTER TRIGGER ESTUDIANTE.tg_ESTUDIANTE_UPDATE  DISABLE  
          ALTER TRIGGER  ESTUDIANTE.tg_ESTUDIANTE_DELETE  DISABLE 
          ALTER TRIGGER ESTUDIANTE.tg_ESTUDIANTE_INSERT  DISABLE
          ALTER TRIGGER ESTUDIANTE.tg_ESTUDIANTE_BECA_UPDATE  DISABLE 
            ALTER TRIGGER ESTUDIANTE.tg_ESTUDIANTE_BECA_DELETE  DISABLE
            ALTER TRIGGER ESTUDIANTE.tg_ESTUDIANTE_BECA_INSERT DISABLE 
           ALTER TRIGGER ESTUDIANTE.tg_ESTUDIANTE_CARRERA_UPDATE DISABLE
         ALTER TRIGGER  ESTUDIANTE.tg_ESTUDIANTE_CARRERA_DELETE DISABLE
          ALTER TRIGGER ESTUDIANTE.tg_ESTUDIANTE_CARRERA_INSERT DISABLE
          ALTER TRIGGER ESTUDIANTE.tg_ESTUDIANTE_CURSO_UPDATE DISABLE
          ALTER TRIGGER ESTUDIANTE.tg_ESTUDIANTE_CURSO_DELETE DISABLE
          ALTER TRIGGER ESTUDIANTE.tg_ESTUDIANTE_CURSO_INSERT DISABLE
          ALTER TRIGGER ESTUDIANTE.tg_ESTUDIANTE_SEDE_UPDATE DISABLE
         ALTER TRIGGER ESTUDIANTE.tg_ESTUDIANTE_SEDE_UPDATE DISABLE
           ALTER TRIGGER ESTUDIANTE.tg_ESTUDIANTE_SEDE_INSERT DISABLE
          ALTER TRIGGER ESTUDIANTE.tg_ESTUDIANTE_TELEFONO_UPDATE DISABLE
         ALTER TRIGGER ESTUDIANTE.tg_ESTUDIANTE_TELEFONO_DELETE DISABLE
         ALTER TRIGGER ESTUDIANTE.tg_ESTUDIANTE_TELEFONO_INSERT DISABLE
         ALTER TRIGGER ESTUDIANTE.tg_TELEFONO_UPDATE DISABLE
        ALTER TRIGGER ESTUDIANTE.tg_TELEFONO_DELETE DISABLE
        ALTER TRIGGER ESTUDIANTE.tg_TELEFONO_INSERT ENABLE

			
		END IF;
			
	END IF;
END$$