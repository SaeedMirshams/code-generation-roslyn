grammar PlantUMLGrammer;

file : STARTUML (namespace_def | type_definition)* SPACE? ENDUML EOF
;

namespace_def : NAMESPACE SPACE namespace_name SPACE? AQOLADBAZ (type_definition)* AQOLADBASTE 
;

type_definition
    : SPACE* (note_expr
    | enum_def
    | class_def
    | extrafield
    | relation
    | Singleline_comment
    )
    ;

 
enum_def : ENUM SPACE enum_name SPACE? streotype_def? (SPACE color)? enum_field_def_block? ;

field_def_block : AQOLADBAZ field_def* SPACE* AQOLADBASTE ;

field_def : SPACE* method_field? fieldstreotype* (accessor SPACE? fieldType SPACE)? fieldName ;


enum_field_def_block : AQOLADBAZ enum_field_def* AQOLADBASTE ;

enum_field_def : SPACE* method_field? fieldstreotype* (accessor SPACE? fieldType SPACE)? fieldName SPACE* enum_field_streo_type* ;

enum_field_streo_type : DLT enumcomment DGT;

enumcomment : ~(DGT)* ;

fieldstreotype : DLT streotypename DGT ;

method_field: '{method}' 
            | '{field}' 
;


class_def : ABSTRACT? CLASS SPACE class_name SPACE? streotype_def* (SPACE color)?  field_def_block?
          | interface_def
           ;
 
 streotype_def : DLT streotypename  DGT 
               | DLT streotypename  SPACE? SLT generic_name SPACE? DGT SGT 
               | DLT streotypename  SPACE? SLT generic_name SPACE? SGT SPACE DGT ;

 SLT:'<';
 DLT: SLT SLT;
 SGT:'>';
 DGT:SGT SGT;

 streotypename :  identifier ;
 
 generic_name : identifier ;

 multi_line_comment : '\\\'' comment '\'\\' ;

 comment : somethings ;

 
interface_def
    : INTERFACE SPACE interface_name
    ;

color: Color ;


extrafield : ownerClass SPACE? COLON SPACE accessor SPACE? fieldstreotype* fieldType SPACE fieldName
           | ownerClass SPACE? COLON SPACE accessor SPACE? fieldType SPACE methodName SPACE? '(' SPACE? ')'
;


relation : from SPACE multiplicity_from? SPACE? relationType SPACE? multiplicity_to? SPACE to (SPACE COLON direction? SPACE? linktext SPACE? direction?)? ;

direction: '<' | '>';

multiplicity_from : STRING ;
multiplicity_to : STRING ;

from : identifier;
to : identifier ;
interface_name : Identifier;

linktext : somethings ;

relationType: '--|>'
            | '--'
            | '<|--'
            | '-->'
            | '<-->'
            | '<--'
            | '*--'
            | '--*'
            | '*-'
            | '-*'
            | '-'
            ;


accessor : '+'
         | '-'
         | '#'
         | '~'
         ;

fieldName : identifier 
;

methodName : identifier 
;

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

Singleline_comment : '\''  ~[\r\n]* [\r\n ];

NewLine : ('\r' '\n' | '\n' SPACE*) -> skip;

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

Color : '#' ([a-f0-9]+ | [A-F0-9]+)
;
