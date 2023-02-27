Coding task
For this coding task, please check your solution into an accessible repository such as GitHub and provide
the link for us to review.

1. Write a simple program that implements a timer countdown on a web page. The front end
should be a web page, written in Angular 12 or higher, that uses .Net web services API for
the following:
a. Retrieve the starting time from the web API as well as a short inventory list such as:
<inventory>
    <item>
        <Description>Table</Description>
        <Count>2</Count>
    </item>
    <item>
        <Description>Chair</Description>
        <Count>18</Count>
        </item>
<inventory>
(this may be XML or JSON)
b. The inventory list should be retrieved from persistent storage using Entity Framework
c. Conduct the countdown within the web browser, visually displaying the countdown
d. Call a second web API to indicate the timer is finished.
