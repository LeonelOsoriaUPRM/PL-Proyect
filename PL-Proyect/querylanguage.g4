grammar querylanguage;
 
query
    : expression
    ;
 
expression
    : STRING
    | NUMBER
    | expression 'AND' expression
    | expression 'OR' expression
    | 'Left Hand' expression 'Speed' expression 
    | 'Right Hand' expression 'Speed' expression 
    ;
 
WS  : (' '|'\t'|'\r'|'\n')+ -> skip;
 
STRING : '"' .*? '"';
SIGN
   : ('+' | '-')
   ;
NUMBER  
    : SIGN? ( [0-9]* '.' )? [0-9]+;