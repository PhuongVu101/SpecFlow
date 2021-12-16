@Database
Feature: StudentRepository


Scenario: FindStudentByID Founded
	Given The students in Database
	| StudentID | Name      | Birthday   |
	| 1         | SuperHero | 01/01/1111 |
	When I call FindStudentByID '1'
	Then I found student


Scenario: FindStudentByID Not Founded
	Given The students in Database
	| StudentID | Name      | Birthday   |
	| 1         | SuperHero | 01/01/1111 |
	When I call FindStudentByID '0'
	Then I do not find student


Scenario Outline: FindStudentByBirthYear
	Given The students in Database
	| StudentID | Name       | Birthday   |
	| 1         | SuperHero  | 01/01/1111 |
	| 2         | SuperWoman | 01/01/1111 |
	| 3         | SuperMan   | 01/01/1110 |
	When I call FindStudentByBirthYear '<Birthday>'
	Then I found '<NumberStudent>' students
	Examples: 
	| Birthday | NumberStudent |
	| 1112     | 0             |
	| 1111     | 2             |
	| 1110     | 1             |
	