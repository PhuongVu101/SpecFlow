Feature: StudentService


Scenario: FindStudentByID
	Given The students
	| StudentID | Name      | Birthday   |
	| 1         | SuperHero | 01/01/1111 |
	And A mock of IStudentRepository
	And Mock function FindStudentByID with data students
	When I call FindStudentByID '1'
	Then Function FindStudentByID is called '1' times
	Then I found the student



	Scenario: FindStudentByID1
	Given The students
	| StudentID | Name      | Birthday   |
	| 1         | SuperHero | 01/01/1111 |
	And A mock of IStudentRepository
	And Mock function FindStudentByID with data students
	When I call FindStudentByID '0'
	Then Function FindStudentByID is called '1' times
	Then I did not find the student
