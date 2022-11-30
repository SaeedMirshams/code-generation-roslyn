grammar PlantUMLGrammer;

file : STARTUML type_definition* SPACE? ENDUML EOF
;

namespace_def : NAMESPACE SPACE namespace_name SPACE? AQOLADBAZ (type_definition)* AQOLADBASTE 
;

type_definition
    : note_expr
    | abstractclass_def
    | interface_def
    | namespace_def
    | class_def
    | extrafield
    | relation
    ;
 

class_def : CLASS SPACE class_name (SPACE color)? ;
 

abstractclass_def 
    : ABSTRACT SPACE CLASS SPACE class_name SPACE 
    | ABSTRACT SPACE class_name 
    | ABSTRACT SPACE class_name SPACE ('#'color)?
    ;

interface_def
    : INTERFACE SPACE interface_name
    ;

color: Color ;

Color : [a-f0-9]+
      | [A-F0-9]+
;

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

ABSTRACT : 'abstract' 
 ;

INTERFACE : 'interface'
;


ownerClass : identifier ;

fieldType : identifier ;



class_name : Identifier ;
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
