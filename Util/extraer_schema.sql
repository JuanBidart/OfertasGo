.mode list
.separator ""
.output schema.sql

SELECT sql || ';' FROM sqlite_master WHERE type='table' AND name NOT LIKE 'sqlite_%' OR type='index' AND name NOT LIKE 'sqlite_%' OR type='view' AND name NOT LIKE 'sqlite_%';

.output stdout