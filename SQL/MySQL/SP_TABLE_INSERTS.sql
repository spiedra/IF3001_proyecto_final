DELIMITER $$
CREATE PROCEDURE AUDITORIA.sp_MOSTRAR_AUDITORIAS(IN param_NOMBRE_TABLA VARCHAR(60))
BEGIN
DECLARE local_table VARCHAR(65535);
DECLARE local_ColumnsList4Values VARCHAR(65535);
DECLARE local_SQL  VARCHAR(65535);

SELECT @local_ColumnsList :=  (INSERT SELECT ', [' + name + ']')
-- print @ColumnsList

SELECT @ColumnsList4Values= STUFF ((
    SELECT ','''''' + ISNULL(TRY_CAST([' + name + '] AS varchar),'''') + '''''' '
    FROM syscolumns
    WHERE id = OBJECT_ID(''+@Table+'') AND name <> 'me'
    FOR XML PATH('')), 1, 1, '')
-- print @ColumnsList4Values

-- Create final SQL query that generates inserts ----------
SELECT @SQL=
        'SELECT ''INSERT INTO ' + @table + ' ('+
        @ColumnsList +
        ') ' +
        'VALUES (' +
        @ColumnsList4Values+
        ')'' Inserts FROM ' + @table 
-- print @SQL

--select @SQL Query -- Query2 Insert values
exec (@SQL)
    
END$$