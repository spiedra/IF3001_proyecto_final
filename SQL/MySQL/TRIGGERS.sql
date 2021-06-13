CREATE SCHEMA AUDITORIA;

CREATE TABLE AUDITORIA.tb_AUDITORIA
(
	 ID INT NOT NULL PRIMARY KEY auto_increment
    ,NOMBRE_TABLA VARCHAR(70)
    ,ESTADO_ATENDIDA BIT NULL DEFAULT 0
);

---------------

DELIMITER $$
CREATE TRIGGER ESTUDIANTE.tg_DIRECCION_UPDATE AFTER UPDATE ON ESTUDIANTE.tb_DIRECCION
FOR EACH ROW
BEGIN
	INSERT INTO AUDITORIA.tb_AUDITORIA(NOMBRE_TABLA, SP_NAME) VALUES('ESTUDIANTE.tb_DIRECCION', 'AUDITORIA.sp_MOSTRAR_DIRECCION');
END;

DELIMITER $$
CREATE TRIGGER ESTUDIANTE.tg_DIRECCION_DELETE AFTER DELETE ON ESTUDIANTE.tb_DIRECCION
FOR EACH ROW
BEGIN
	INSERT INTO AUDITORIA.tb_AUDITORIA(NOMBRE_TABLA, SP_NAME) VALUES('ESTUDIANTE.tb_DIRECCION', 'AUDITORIA.sp_MOSTRAR_DIRECCION');
END;

DELIMITER $$
CREATE TRIGGER ESTUDIANTE.tg_DIRECCION_INSERT AFTER INSERT ON ESTUDIANTE.tb_DIRECCION
FOR EACH ROW
BEGIN
	INSERT INTO AUDITORIA.tb_AUDITORIA(NOMBRE_TABLA, SP_NAME) VALUES('ESTUDIANTE.tb_DIRECCION', 'AUDITORIA.sp_MOSTRAR_DIRECCION');
END;

-------------

DELIMITER $$
CREATE TRIGGER ESTUDIANTE.tg_ESTUDIANTE_UPDATE AFTER UPDATE ON ESTUDIANTE.tb_ESTUDIANTE
FOR EACH ROW
BEGIN
	INSERT INTO AUDITORIA.tb_AUDITORIA(NOMBRE_TABLA, SP_NAME) VALUES('ESTUDIANTE.tb_ESTUDIANTE', 'AUDITORIA.sp_MOSTRAR_ESTUDIANTES');
END;


DELIMITER $$
CREATE TRIGGER ESTUDIANTE.tg_ESTUDIANTE_DELETE AFTER DELETE ON ESTUDIANTE.tb_ESTUDIANTE
FOR EACH ROW
BEGIN
	INSERT INTO AUDITORIA.tb_AUDITORIA(NOMBRE_TABLA, SP_NAME) VALUES('ESTUDIANTE.tb_ESTUDIANTE', 'AUDITORIA.sp_MOSTRAR_ESTUDIANTES');
END;


DELIMITER $$
CREATE TRIGGER ESTUDIANTE.tg_ESTUDIANTE_INSERT AFTER INSERT ON ESTUDIANTE.tb_ESTUDIANTE
FOR EACH ROW
BEGIN
	INSERT INTO AUDITORIA.tb_AUDITORIA(NOMBRE_TABLA, SP_NAME) VALUES('ESTUDIANTE.tb_ESTUDIANTE', 'AUDITORIA.sp_MOSTRAR_ESTUDIANTES');
END;


-----------

DELIMITER $$
CREATE TRIGGER ESTUDIANTE.tg_ESTUDIANTE_BECA_UPDATE AFTER UPDATE ON ESTUDIANTE.tb_ESTUDIANTE_BECA
FOR EACH ROW
BEGIN
	INSERT INTO AUDITORIA.tb_AUDITORIA(NOMBRE_TABLA, SP_NAME) VALUES('ESTUDIANTE.tb_ESTUDIANTE_BECA', 'AUDITORIA.sp_MOSTRAR_ESTUDIANTE_BECA');
END;


DELIMITER $$
CREATE TRIGGER ESTUDIANTE.tg_ESTUDIANTE_BECA_DELETE AFTER DELETE ON ESTUDIANTE.tb_ESTUDIANTE_BECA
FOR EACH ROW
BEGIN
	INSERT INTO AUDITORIA.tb_AUDITORIA(NOMBRE_TABLA, SP_NAME) VALUES('ESTUDIANTE.tb_ESTUDIANTE_BECA', 'AUDITORIA.sp_MOSTRAR_ESTUDIANTE_BECA');
END;


DELIMITER $$
CREATE TRIGGER ESTUDIANTE.tg_ESTUDIANTE_BECA_INSERT AFTER INSERT ON ESTUDIANTE.tb_ESTUDIANTE_BECA
FOR EACH ROW
BEGIN
	INSERT INTO AUDITORIA.tb_AUDITORIA(NOMBRE_TABLA, SP_NAME) VALUES('ESTUDIANTE.tb_ESTUDIANTE_BECA', 'AUDITORIA.sp_MOSTRAR_ESTUDIANTE_BECA');
END;


-------

DELIMITER $$
CREATE TRIGGER ESTUDIANTE.tg_ESTUDIANTE_CARRERA_UPDATE AFTER UPDATE ON ESTUDIANTE.tb_ESTUDIANTE_CARRERA
FOR EACH ROW
BEGIN
	INSERT INTO AUDITORIA.tb_AUDITORIA(NOMBRE_TABLA, SP_NAME) VALUES('ESTUDIANTE.tb_ESTUDIANTE_CARRERA', 'AUDITORIA.sp_MOSTRAR_ESTUDIANTE_CARRERA');
END;


DELIMITER $$
CREATE TRIGGER ESTUDIANTE.tg_ESTUDIANTE_CARRERA_DELETE AFTER DELETE ON ESTUDIANTE.tb_ESTUDIANTE_CARRERA
FOR EACH ROW
BEGIN
	INSERT INTO AUDITORIA.tb_AUDITORIA(NOMBRE_TABLA, SP_NAME) VALUES('ESTUDIANTE.tb_ESTUDIANTE_CARRERA', 'AUDITORIA.sp_MOSTRAR_ESTUDIANTE_CARRERA');
END;


DELIMITER $$
CREATE TRIGGER ESTUDIANTE.tg_ESTUDIANTE_CARRERA_INSERT AFTER INSERT ON ESTUDIANTE.tb_ESTUDIANTE_CARRERA
FOR EACH ROW
BEGIN
	INSERT INTO AUDITORIA.tb_AUDITORIA(NOMBRE_TABLA, SP_NAME) VALUES('ESTUDIANTE.tb_ESTUDIANTE_CARRERA', 'AUDITORIA.sp_MOSTRAR_ESTUDIANTE_CARRERA');
END;


------

DELIMITER $$
CREATE TRIGGER ESTUDIANTE.tg_ESTUDIANTE_CURSO_UPDATE AFTER UPDATE ON ESTUDIANTE.tb_ESTUDIANTE_CURSO
FOR EACH ROW
BEGIN
	INSERT INTO AUDITORIA.tb_AUDITORIA(NOMBRE_TABLA, SP_NAME) VALUES('ESTUDIANTE.tb_ESTUDIANTE_CURSO', ' AUDITORIA.sp_MOSTRAR_ESTUDIANTE_CURSO');
END;


DELIMITER $$
CREATE TRIGGER ESTUDIANTE.tg_ESTUDIANTE_CURSO_DELETE AFTER DELETE ON ESTUDIANTE.tb_ESTUDIANTE_CURSO
FOR EACH ROW
BEGIN
	INSERT INTO AUDITORIA.tb_AUDITORIA(NOMBRE_TABLA, SP_NAME) VALUES('ESTUDIANTE.tb_ESTUDIANTE_CURSO', ' AUDITORIA.sp_MOSTRAR_ESTUDIANTE_CURSO');
END;


DELIMITER $$
CREATE TRIGGER ESTUDIANTE.tg_ESTUDIANTE_CURSO_INSERT AFTER INSERT ON ESTUDIANTE.tb_ESTUDIANTE_CURSO
FOR EACH ROW
BEGIN
	INSERT INTO AUDITORIA.tb_AUDITORIA(NOMBRE_TABLA, SP_NAME) VALUES('ESTUDIANTE.tb_ESTUDIANTE_CURSO', ' AUDITORIA.sp_MOSTRAR_ESTUDIANTE_CURSO');
END;


-----

DELIMITER $$
CREATE TRIGGER ESTUDIANTE.tg_ESTUDIANTE_SEDE_UPDATE AFTER UPDATE ON ESTUDIANTE.tb_ESTUDIANTE_SEDE
FOR EACH ROW
BEGIN
	INSERT INTO AUDITORIA.tb_AUDITORIA(NOMBRE_TABLA, SP_NAME) VALUES('ESTUDIANTE.tb_ESTUDIANTE_SEDE', 'AUDITORIA.sp_MOSTRAR_ESTUDIANTE_SEDE');
END;


DELIMITER $$
CREATE TRIGGER ESTUDIANTE.tg_ESTUDIANTE_SEDE_DELETE AFTER DELETE ON ESTUDIANTE.tb_ESTUDIANTE_SEDE
FOR EACH ROW
BEGIN
	INSERT INTO AUDITORIA.tb_AUDITORIA(NOMBRE_TABLA, SP_NAME) VALUES('ESTUDIANTE.tb_ESTUDIANTE_SEDE', 'AUDITORIA.sp_MOSTRAR_ESTUDIANTE_SEDE');
END;


DELIMITER $$
CREATE TRIGGER ESTUDIANTE.tg_ESTUDIANTE_SEDE_INSERT AFTER INSERT ON ESTUDIANTE.tb_ESTUDIANTE_SEDE
FOR EACH ROW
BEGIN
	INSERT INTO AUDITORIA.tb_AUDITORIA(NOMBRE_TABLA, SP_NAME) VALUES('ESTUDIANTE.tb_ESTUDIANTE_SEDE', 'AUDITORIA.sp_MOSTRAR_ESTUDIANTE_SEDE');
END;


---

DELIMITER $$
CREATE TRIGGER ESTUDIANTE.tg_ESTUDIANTE_TELEFONO_UPDATE AFTER UPDATE ON ESTUDIANTE.tb_ESTUDIANTE_TELEFONO
FOR EACH ROW
BEGIN
	INSERT INTO AUDITORIA.tb_AUDITORIA(NOMBRE_TABLA, SP_NAME) VALUES('ESTUDIANTE.tb_ESTUDIANTE_TELEFONO', 'AUDITORIA.sp_MOSTRAR_ESTUDIANTE_TELEFONO');
END;


DELIMITER $$
CREATE TRIGGER ESTUDIANTE.tg_ESTUDIANTE_TELEFONO_DELETE AFTER DELETE ON ESTUDIANTE.tb_ESTUDIANTE_TELEFONO
FOR EACH ROW
BEGIN
	INSERT INTO AUDITORIA.tb_AUDITORIA(NOMBRE_TABLA, SP_NAME) VALUES('ESTUDIANTE.tb_ESTUDIANTE_TELEFONO', 'AUDITORIA.sp_MOSTRAR_ESTUDIANTE_TELEFONO');
END;


DELIMITER $$
CREATE TRIGGER ESTUDIANTE.tg_ESTUDIANTE_TELEFONO_INSERT AFTER INSERT ON ESTUDIANTE.tb_ESTUDIANTE_TELEFONO
FOR EACH ROW
BEGIN
	INSERT INTO AUDITORIA.tb_AUDITORIA(NOMBRE_TABLA, SP_NAME) VALUES('ESTUDIANTE.tb_ESTUDIANTE_TELEFONO', 'AUDITORIA.sp_MOSTRAR_ESTUDIANTE_TELEFONO');
END;


---

DELIMITER $$
CREATE TRIGGER ESTUDIANTE.tg_TELEFONO_UPDATE AFTER UPDATE ON ESTUDIANTE.tb_TELEFONO
FOR EACH ROW
BEGIN
	INSERT INTO AUDITORIA.tb_AUDITORIA(NOMBRE_TABLA, SP_NAME) VALUES('ESTUDIANTE.tb_TELEFONO', 'AUDITORIA.sp_MOSTRAR_TELEFONO');
END;


DELIMITER $$
CREATE TRIGGER ESTUDIANTE.tg_TELEFONO_DELETE AFTER DELETE ON ESTUDIANTE.tb_TELEFONO
FOR EACH ROW
BEGIN
	INSERT INTO AUDITORIA.tb_AUDITORIA(NOMBRE_TABLA, SP_NAME) VALUES('ESTUDIANTE.tb_TELEFONO', 'AUDITORIA.sp_MOSTRAR_TELEFONO');
END;


DELIMITER $$
CREATE TRIGGER ESTUDIANTE.tg_TELEFONO_INSERT AFTER INSERT ON ESTUDIANTE.tb_TELEFONO
FOR EACH ROW
BEGIN
	INSERT INTO AUDITORIA.tb_AUDITORIA(NOMBRE_TABLA, SP_NAME) VALUES('ESTUDIANTE.tb_TELEFONO', 'AUDITORIA.sp_MOSTRAR_TELEFONO');
END;



