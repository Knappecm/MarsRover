# MarsRover
Mars Rover DealerOn Application Code Assignment

# Behavior
This C# .Net Application will pull up a Swagger API when run. Please use the /mapArea API Endpoint when testing.<br>
The /mapArea Endpoint requests data as the following(comma delimited):<br>
"X boundary Y Boundary,X Rover Position Y Rover Position Rover Direction,Instructions"
i.e.<br>
"5 5,1 2 N,LMLMLMLMM,3 3 E,MMRMMRMRRM"<br>

the endpoint will return the results as:<br>
"1 3 N<br>
 5 1 E"


*NOTE: No Behavior was specificed for boundary expections. My Behavior is to not continue if the rover is at bounds i.e. if the rover is at the boundary as asked to move forward again, it will stay at boundary* 
