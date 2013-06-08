set _my_datetime=%date%_%time%
set _my_datetime=%_my_datetime: =_%
set _my_datetime=%_my_datetime::=%
set _my_datetime=%_my_datetime:/=_%
set _my_datetime=%_my_datetime:.=_%

java -jar "D:\Program Files\SeleniumRC\selenium-server.jar" -htmlsuite *opera "http://test.telerikacademy.com/SoftwareAcademy/Candidate" "C:\Documents and Settings\Desktop\SeleniumRC\TSuiteCandidate.html" "C:\Documents and Settings\Desktop\Result_%_my_datetime%.html"
