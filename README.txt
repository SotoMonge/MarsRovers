
#NOTES ABOUT THE CODE

***The program was created in console application.***
***Classes are divided according to the function of their methods.***
***RoverClass is the class that starts the whole procedure.***
***The position of the rover is found in the origin variable and this is the one that is assigned the final value, 
	   another variable can be added for the final result.***
***The coordinates are updated within the variable without having to assign memory to the entire grid that represents 
	   the plane where the rover will move, I did this to avoid using too much memory if the final result is the position 
	   in coordinates of the rover and its heading , but it can be added and with few changes would return the same result.***
***I added some comments to the code and I hope they are helpful so that I can explain the logic I used a little better.***

##Start the application
1. Run the application(F5).
2. Type the max size of the grid:
   -x axis, ENTER.
   -y axis ENTER.
3. Type the origin of the rover:
   -x axis, ENTER.
   -y axis, ENTER.
   -where rover is facing(cardinal compass points), ENTER.
   **If the position of x or y are greater or less than the grid the origin on that axis then it will take the position of the 
   maximum value of the respective axis.**
4. write the instructions for rover:
   -L:90 degrees left.
   -R:90 degrees right.
   -M:move froward.
   -ENTER
5. If you want to start over with another type of position, type and then it ***will start again from step 3, for which a new value 
   will no longer be assigned to the grid***.