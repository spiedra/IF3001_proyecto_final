
CREATE TRIGGER ESTUDIANTE.tg_ESTUDIANTE
ON ESTUDIANTE.tb_ESTUDIANTE
AFTER DELETE, INSERT, UPDATE
AS
     BEGIN
         --SET NOCOUNT ON;
         INSERT INTO AUDITORIA.tb_AUDITORIA (NOMBRE_TABLA) VALUES ('ESTUDIANTE.tb_ESTUDIANTE')
                
     END;

	 ----------------
	 CREATE TRIGGER ESTUDIANTE.tg_ESTUDIANTE_BECA
ON ESTUDIANTE.tb_ESTUDIANTE_BECA
AFTER DELETE, INSERT, UPDATE
AS
     BEGIN
         --SET NOCOUNT ON;
         INSERT INTO AUDITORIA.tb_AUDITORIA (NOMBRE_TABLA) VALUES ('ESTUDIANTE.tb_ESTUDIANTE_BECA')
                
     END;

	 ----------------
	 CREATE TRIGGER ESTUDIANTE.tg_ESTUDIANTE_CARRERA
ON ESTUDIANTE.tb_ESTUDIANTE_CARRERA
AFTER DELETE, INSERT, UPDATE
AS
     BEGIN
         --SET NOCOUNT ON;
         INSERT INTO AUDITORIA.tb_AUDITORIA (NOMBRE_TABLA) VALUES ('ESTUDIANTE.tb_ESTUDIANTE_CARRERA')
                
     END;

	 ----------------
	 CREATE TRIGGER ESTUDIANTE.tg_ESTUDIANTE_CURSO
ON ESTUDIANTE.tb_ESTUDIANTE_CURSO
AFTER DELETE, INSERT, UPDATE
AS
     BEGIN
         --SET NOCOUNT ON;
         INSERT INTO AUDITORIA.tb_AUDITORIA (NOMBRE_TABLA) VALUES ('ESTUDIANTE.tb_ESTUDIANTE_CURSO')
                
     END;

	 ----------------
	 CREATE TRIGGER ESTUDIANTE.tg_ESTUDIANTE_SEDE
ON ESTUDIANTE.tb_ESTUDIANTE_SEDE
AFTER DELETE, INSERT, UPDATE
AS
     BEGIN
         --SET NOCOUNT ON;
         INSERT INTO AUDITORIA.tb_AUDITORIA (NOMBRE_TABLA) VALUES ('ESTUDIANTE.tb_ESTUDIANTE_SEDE')
                
     END;

	 ----------------

	  CREATE TRIGGER ESTUDIANTE.tg_ESTUDIANTE_TELEFONO
ON ESTUDIANTE.tb_ESTUDIANTE_TELEFONO
AFTER DELETE, INSERT, UPDATE
AS
     BEGIN
         --SET NOCOUNT ON;
         INSERT INTO AUDITORIA.tb_AUDITORIA (NOMBRE_TABLA) VALUES ('ESTUDIANTE.tb_ESTUDIANTE_TELEFONO')
                
     END;

	   CREATE TRIGGER ESTUDIANTE.tg_TELEFONO
ON ESTUDIANTE.tb_TELEFONO
AFTER DELETE, INSERT, UPDATE
AS
     BEGIN
         --SET NOCOUNT ON;
         INSERT INTO AUDITORIA.tb_AUDITORIA (NOMBRE_TABLA) VALUES ('ESTUDIANTE.tb_TELEFONO')
                
     END;