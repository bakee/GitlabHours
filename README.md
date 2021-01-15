# GitlabHours

This is a simple library to convert gitlab spent and estimated time in hours. Gitlab uses the following units:
1. **mo** (Months = 4 Weeks)
1. **w** (Weeks = 5 Days)
1. **d** (Days = 8 hours)
1. **h** (Hours)
1. **m** (Minutes)

This library takes a time string and convert it to plain hours.
```
Examaple: 3mo 2w 4d 6h -> 598h.
```
It can also accumulate multiple time inputs:
```
Example: 3mo 2d 4d 5w 4mo 3h 2w 50m 9w 20m 4d 50m -> 1845h
```

## Main Library
```GitlabHoursLib``` is the main library project.

## Samples
There is a sample console app ```GitlabHoursConsole```. There are other unfinished apps for android and iOS.

### Building the sample
Open the solution in visual studio and set ```GitlabHoursConsole``` as the startup project. Now Build, run or debug to see the console. If you put the hours in gitlab hours format it'll show you the total hours. To exit just type ```exit```.
