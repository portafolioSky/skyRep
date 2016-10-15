select 'drop table '|| table_name ||' cascade constraint;' from user_tables;
select 'drop sequence '|| sequence_name||';' from user_sequences;
select 'drop '|| object_type||' '||object_name||';' from user_procedures;