grammar PlantUMLGrammer;

file : STARTUML type_definition* SPACE? ENDUML EOF
;

namespace_def : NAMESPACE SPACE namespace_name SPACE? AQOLADBAZ (type_definition)* AQOLADBASTE 
;

type_definition
    : note_expr
    | namespace_def
    | enum_def
    | class_def
    | extrafield
    | relation
    | singleline_comment
    ;
 
enum_def : ENUM SPACE enum_name SPACE? streotype_def? (SPACE color)? field_def_block? ;

field_def_block : AQOLADBAZ field_def* AQOLADBASTE ;

field_def : method_field? (accessor SPACE? fieldType SPACE)? fieldName
;

method_field: '{method}' 
            | '{field}' 
;


class_def : CLASS SPACE class_name SPACE? streotype_def? (SPACE color)?  field_def_block?
          | abstractclass_def
          | interface_def
           ;
 
 streotype_def : '<<' streotypename '>>' ;

 streotypename : identifier ;

 singleline_comment : '\'' rest_of_line ;

 rest_of_line 
 : ~NewLine*
 ;

abstractclass_def 
    : ABSTRACT SPACE CLASS SPACE class_name SPACE? streotype_def? SPACE 
    | ABSTRACT SPACE class_name 
    | ABSTRACT SPACE class_name SPACE? streotype_def? SPACE ('#'color)?
    ;

interface_def
    : INTERFACE SPACE interface_name
    ;

color: Color ;


extrafield : ownerClass SPACE? COLON SPACE accessor SPACE? fieldType SPACE fieldName
           | ownerClass SPACE? COLON SPACE accessor SPACE? fieldType SPACE fieldName SPACE? '(' SPACE? ')'
;


relation : from SPACE relationType SPACE to (COLON direction? SPACE? linktext SPACE? direction?)? ;

direction: '<' | '>';

from : identifier;
to : identifier ;
interface_name : Identifier;

linktext : somethings ;
relationType: '--|>'
            | '--'
            | '<|--'
            | '-->'
            | '<--'
            | '*--'
            | '*-'
            | '-'
            ;


accessor : '+'
         | '-'
         | '#'
         | '~'
         ;
fieldName : identifier ;


NAMESPACE : 'namespace' | 'package'
;

CLASS : 'class' 
;

ENUM : 'enum' 
;

ABSTRACT : 'abstract' 
 ;

INTERFACE : 'interface'
;


ownerClass : identifier ;

fieldType : identifier ;



class_name : Identifier ;
enum_name : Identifier ;

namespace_name : dotIdentifier;

COLON: ':';

STRING : '"' .*? '"';
SIGN
   : ('+' | '-')
   ;
NUMBER  
    : SIGN? ( [0-9]* '.' )? [0-9]+;

STARTUML :'@startuml'
;

ENDUML : '@enduml'
;

AQOLADBAZ : '{'
;

AQOLADBASTE : '}'
;

SPACE: [ \t]+ ;

NewLine : ('\r' '\n'? | '\n') SPACE* -> skip;

NOTE: 'note'
;

identifier: Identifier
          |'"' Identifier '"'
          | STRING
;

Identifier: [a-zA-Z_][a-zA-Z0-9_]* 
            ;


dotIdentifier :
              identifier 
             | identifier '.' dotIdentifier
             | STRING 
;

note_expr : NOTE SPACE somethingsToEndNote  ENDNOTE
;

somethingsToEndNote: ~(ENDNOTE)*;

ENDNOTE: 'end' SPACE 'note'
;

somethings : .*?
          | Unicode*
;

Unicode : [\p{Letter}] ;

Color : [a-f0-9]+
      | [A-F0-9]+
;
