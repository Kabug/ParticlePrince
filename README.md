# ParticlePrince
A project to demonstrate hydraulic erosion on terrestrial planets in real time

# Subdivisions
![](https://i.imgur.com/7B5kyHo.gif)

# Heightmaps

V1 Early Forms:<br />
![](https://i.imgur.com/2LVsTer.gif)

V1 Heightmap w/ Shaders:<br />
![](https://i.imgur.com/VHVVvaD.gif)

V2 Heightmap w/ Shaders: <br />
![](https://user-images.githubusercontent.com/22303067/123505388-a7a0fb80-d613-11eb-844d-c6520fb5b855.gif)

## 9 - Credit Practicum Report

# Procedural Planet Generation with

# Hydraulic Erosion

## British Columbia Institute of Technology

## BTECH Games Development

## Aug. 30th, 202 1

Kabilan Thangarajah

A


## Table of Contents



- Page 1 of
- 1. Student Background
   - 1.1 Education
      - 2018 - Present Computer Systems Technology BTECH Game Developing
      - Sept 2016 - 2018 Computer Information Technology (CIT)
   - 1.2 Work Experience
      - June 2019 - Present Technical Support Analyst
      - July 2018 - August 2018 Information Technology Assistant
   - 1.3 Projects
      - Rock Ryder Reloaded
      - Simple City Tour
      - Senior Assistance Center
      - Tato-inn a Fast-Food Restaurant
- 2. Project Description
- 3. Problem Statement and Background
- 4. Scope and Depth
- 5. Test Plan
   - Quality Assurance (QA)
   - System Testing - Load Testing
   - System Testing - Load Testing (Results)
   - Functional Testing – User Acceptance Testing (UAT)
      - Geodesic Polyhedron Generation
      - Geodesic Polyhedron Generation (Results)
      - Height Map Generation on Planes
      - Height Map Generation on Planes (Results)
      - Gravity
      - Gravity (Results)
      - Hydraulic Erosion
      - Hydraulic Erosion (Results)
   - Collection of Planets created by Testers.................................................................................................
      - Gg Son - Andy
      - Kanem – Vipulan
      - Aunty Earth – Terry
- Page 2 of
- 6. Methodology
   - Technologies
   - Approach
      - Major Milestones:
- 7. System/Software Architecture Diagram
      - Inertia
      - Carry Capacity
      - Deposition Speed
      - Erosion Speed
      - Evaporation Speed
      - Erosion Radius
- 8. Innovation
   - Hydraulic Erosion
   - Hydraulic Erosion (Results)
      - Before and After - 0 Subdivisions
      - Before and After - 1 Subdivision
      - Before and After - 2 Subdivisions
      - Before and After - 3 Subdivisions
      - Before and After - 4 Subdivisions
      - Before and After - 5 Subdivisions
      - Before and After - 6 Subdivisions
- 9. Complexity
   - Geodesic Polyhedron Generation
   - Hydraulic Erosion
- 10. Technical Challenges
   - Geodesic Polyhedron Generation
   - Geodesic Polyhedron Generation (Results)
      - Vertices generation
      - Drawing Triangles................................................................................................................................
      - Creating a Rectangle by Drawing Squares
      - Creating a Rectangular Prism
      - Subdivision
   - Height Map Generation
- Page 3 of
   - Height Map Generation (Results)
      - First attempt of height map generation
      - Overlapping a sphere to represent the ocean
      - New Algorithm
      - Issues with New Algorithms
      - Fixed Algorithm for Heightmap...........................................................................................................
      - Experimenting with Shaders
      - Algorithm with Varying Heights
      - Masking Problems when Rigid Filter is on Simple Filter
      - Finish Product after bugs were fixed
      - Finished Product with Updated Shaders.............................................................................................
   - Simulating Gravity on a Planet
   - Simulating Gravity on a Planet (Results)
- 11. Development Schedule and Milestones
   - Week
   - Week 2 – Milestone: Height Map Generation on Planes (16 Hours)......................................................
   - Week 3 – Milestone: Apply Heightmaps to Sphere Faces (24 Hours)
   - Week 4 – Milestone: Simulate Gravity and 1st Person Controls (24 Hours)
   - Week
   - Week 6 – Milestone: Particle Based Erosion on Heightmaps on Planes (24 Hours)
   - Week 7 – Milestone: Particle Based Erosion on Heightmaps on Sphere Faces (48 Hours)
   - Week 8 – Milestone: Final Optimization (32 Hours)
   - Week
   - Week
   - Week
- 12. Deliverables
- 13. Conclusion and Expertise Development
- 14. References
- 15. Change Log


Page **4** of **46**

## 1. Student Background

#### Most of my development knowledge is in web development and data analysis. I do have some

#### experience with game development in school, however I have not applied it in the real world

#### quite yet. However, I have worked on a game that included procedural generation before, so I

#### have some experience in this aspect of the project.

### 1.1 Education

#### 2018 - Present Computer Systems Technology BTECH Game Developing

_British Columbia Institute of Technology_
● Learn physics hands-on by using formulas in the unity engine
● Learn how to create shaders using OpenGL
● Create a game on Unity using C#
● Create a game for iOS using Objective-C and C++ through XCode
● Create a game on android using Java through Android Studio

#### Sept 2016 - 2018 Computer Information Technology (CIT)

_British Columbia Institute of Technology_

```
● Two-year computing program focuses on diagnosing IT system problems and providing
● solutions
● Knowledge of network and information security
● Implementing emerging tools and technologies and working with hands-on work on industry
projects
● Learn web development, mobile development
● Learn Cloud Computing via AWS
```
### 1.2 Work Experience

#### June 2019 - Present Technical Support Analyst

_Finning International_

Working with the EPS team to create scripts, provide onsite support and I am currently working on
developing a solution for tracking, processing and outputting device orders by full-stack developing a

React app.

```
● Orders-Webapp
○ Frontend:
■ React
■ Bootstrap
○ Backend
■ GQL
■ Apollo
■ Prisma
■ MySQL
● Scripts/Data Analysis
```

Page **5** of **46**

```
● Python - Mainly for data aggregation, comparison and analysis:
○ Pandas
○ NumPy
○ Beautiful Soup
○ Selenium
● VBA
● Batch/PowerShell
```
#### July 2018 - August 2018 Information Technology Assistant

_Digital Media Academy_
● Fixed hardware and software issues internally and globally via slack
● Assisted teachers to educate youth
● Tier 1 and 2 tech support
● Taught Python
● Taught TinkerCAD
● Helped students with Raspberry Pi projects
● Organized games for youth to play during lunch
● Set up internal Lan networks

### 1.3 Projects

#### Rock Ryder Reloaded

```
● A personal project that built upon a school game project
● Created assets using Blender
● Launcher type game consisting of glider physics and power-ups
● Created a shop which allowed players to improve stats based on purchases
● Created a simple storyline with cutscenes
● The project worked on with a team
● https://github.com/KabilanMT/RockRyderReloaded
```
#### Simple City Tour

```
● Mobile Tour App for Apple/Android
● Hosted Database and Server on Amazon Web Services
● Able to create accounts for the App
● App would download cities whenever the database was updated automatically.
● Had multiple sightseeing locations for each city.
● Would automatically play a recorded message whenever you reached the
● locations.
● https://github.com/SimpleCityTours/SimpleCityTours
```
#### Senior Assistance Center

```
● Built a website for users to obtain help from the correct sources
● Portfolio
```

Page **6** of **46**

```
● Created with
● Implemented a Chat feature for direct user support
● Created user-friendly user interface
● Technologies Used: HTML5, Javascript, CSS, Wordpress
● Website Link: https://helpformomanddad.today/
```
#### Tato-inn a Fast-Food Restaurant

```
● Online Kiosk for a fast food restaurant
● Implemented a database to store user’s order
● Connected web server and database together for function use
● Deployment on Heroku server and Github
● Technologies Used: AngularJS, Bootstrap HTML5, PostgresQL, Javascript
```
## 2. Project Description

#### The project I am working on is procedurally generated planets that will undergo hydraulic

#### erosion. These planets will be like asteroids in The Little Prince where a planet will be

#### significantly smaller than what it would in the real world. My first goal is to generate a geodesic

#### sphere, then to procedurally modify these sphere's terrain with Perlin noise. I looked up a few

#### alternate ways to create height maps like blurred random noise, fractal noise etc.

#### Unfortunately, none of these are new or innovative ideas. Instead, my innovation will be to

#### create height maps with Perlin noise. Afterwards, I will alter them in real-time with hydraulic

#### erosion by implementing a particle-based erosion algorithm I found. I will also not be using any

#### external libraries for this project.

#### I have created a piece of concept art for my end goal of a planet.

#### The ridges in the middle of the planet in the image above, I would like to create with the

#### erosion.


Page **7** of **46**

#### Hydraulic erosion is a recent idea being used in tandem with procedural generation, but I have

#### not seen it happen in a spherical world. Once I have finished the features of the project, I will

#### create a solar system with these procedurally generated planets to display differentiations and

#### demonstrate my algorithm with sliders to edit them. There will also be a first-person view of

#### the generated planets to view them up close.

## 3. Problem Statement and Background

#### The problem with procedurally generating terrain is that it is hard to make it look natural. For

#### this reason, over time we have developed many methods to refine it. One of these recent

#### methods is hydraulic erosion. A way to describe this method is to imagine a droplet of water

#### falling onto the terrain. Using its initial momentum from gravity it continues down the terrain

#### until it loses its velocity. As it is moving down, it will take pieces of the terrain with it and once

#### stopped it will drop it off where it ends up. Now we do this many more times across the terrain

#### and eventually, the terrain begins to look more and more realistic. This is called particle-based

#### erosion.^1

#### I would like to apply this method in real-time to a spherical world and eventually create many

#### detailed and realistic looking planets to showcase. I will go more into how the presentation will

#### be in the scope and depth.

#### The two main problems I want to solve is to have planets with natural terrain and have them

#### undergo hydraulic erosion without having a large performance decline in fps.

## 4. Scope and Depth

#### The scope of the project is to have a realistic and real-time terrain generation. I would like the

#### planets to have gravity and to have no issues with the textures. For the terrain generation, the

#### two most important things that are required for it to look realistic is the Perlin noise map and

#### hydraulic erosion. To present the planets, I would like to have the planets editable with sliders

#### to change the height maps and options as well as the level of erosion. I will create a few

#### example planets displayed in a static solar system and create a 1st person view to help explore

#### the planets.

#### Creating a game is out of scope for this project. I will also not be creating atmospheres or a

#### realistic solar system with orbit.

(^1) Reference _Implementation of a Method for Hydraulic Erosion_ for a more detailed explanation


Page **8** of **46**

```
In Scope Out of Scope
Sphere Generation A Game
Dynamic Textures based off height An Atmosphere
Heightmap Generation Realistic Solar System with Orbit
Hydraulic Erosion
1 st person controls to view planets close up
Simple solar system to show off different types of
planets the project can make
```
## 5. Test Plan

### Quality Assurance (QA)

#### I will have QA testers perform tests throughout the project whenever a main feature is

#### functionally implemented. This way I will be able to get their opinions and make any changes

#### right away instead of making changes near the end and having to redo other portions of the

#### code.

### System Testing - Load Testing

#### After implementing a feature, I will be commencing load tests to see at what point FPS will see

#### a significant decline. I will create graphs to help observe the effects each feature will have on

#### performance to find a golden ratio. This will also help with identifying potential bottlenecks that

#### I can attempt to solve early. Eventually once I adapt this to a game, I will have to make sure the

#### performance is optimized so this is very important.

### System Testing - Load Testing (Results)

#### These are the results of doing testing with different types of optimizations I implemented after

#### hearing responses from my QA testers and reading more about optimization in erosion

#### algorithms.

```
0
```
```
20
```
```
40
```
```
60
```
```
80
```
```
100
```
```
120
```
```
140
```
```
0 1 2 3 4 5 6 7 8
```
Performance of 200 Iterations, 10 at a Time

```
None
Variable Sediment Reduction with Sediment Dropoff
Variable Sediment Reduction with Sediment Dropoff and Sediment Cap
```

Page **9** of **46**

#### • None:

#### o No optimization Implemented

#### • Variable Sediment Reduction with Sediment Dropoff:

#### o Added a 50 percent chance of sediment dissolution per collision which reduced

#### the performance at 5 subdivisions, but the performance continued to be a

#### problem at 6 subdivisions

#### o Droplets collect sediment and drop off if they reach sea level, or exist for too

#### long without moving which means they have reached a point where they lose all

#### momentum

#### • Variable Sediment Reduction with Sediment Dropoff and Sediment Cap:

#### o Implemented a limit on how much sediment a droplet can hold which

#### significantly increased the performance.

### Functional Testing – User Acceptance Testing (UAT)

#### • Height Map Generation on Planes

#### • Apply Heightmaps to Sphere Faces

#### • Simulate Gravity on Planets/1st Person Controls

#### • Particle based Erosion on Heightmap on Plane

#### • Particle Based Erosion on Heightmaps on Sphere Faces

#### • Final optimization

#### For UAT testing I will be commencing tests on multiple different types of users and computers

#### to see if the project is accessible for them.

#### These UAT tests will be performed at each milestone in tandem with my QA tests.

#### Geodesic Polyhedron Generation

#### Acceptance

#### Requirements

#### Accepted Rejected Comments

```
Are you comfortable with
the size of the sphere you
can create?
Are the number of
artifacts acceptable?
Are the number of
subdivisions allowed
acceptable? Does it look
like a sphere?
```

Page **10** of **46**

#### Geodesic Polyhedron Generation (Results)

#### Michael

#### Acceptance

#### Requirements

#### Accepted Rejected Comments

```
Are you comfortable with
the size of the sphere you
can create?
```
##### ✓

```
Are the number of
artifacts acceptable?
```
```
✓ I’m not able to see
any artifacts
Are the number of
subdivisions allowed
acceptable? Does it look
like a sphere?
```
##### ✓

#### Andy

#### Acceptance

#### Requirements

#### Accepted Rejected Comments

```
Are you comfortable with
the size of the sphere you
can create?
```
##### ✓

```
Are the number of
artifacts acceptable?
```
(^) ✓ Snow mountains
can be more
detailed
Are the number of
subdivisions allowed
acceptable? Does it look
like a sphere?

##### ✓

#### Vipulan

#### Acceptance

#### Requirements

#### Accepted Rejected Comments

```
Are you comfortable with
the size of the sphere you
can create?
```
##### ✓

```
Are the number of
artifacts acceptable?
```
(^) ✓ The mountains have
a noticeable
number of artifacts
Are the number of
subdivisions allowed
acceptable? Does it look
like a sphere?

##### ✓


Page **11** of **46**

#### Terry

#### Acceptance

#### Requirements

#### Accepted Rejected Comments

```
Are you comfortable with
the size of the sphere you
can create?
```
##### ✓

```
Are the number of
artifacts acceptable?
```
```
✓ It is very nice
looking
Are the number of
subdivisions allowed
acceptable? Does it look
like a sphere?
```
```
✓ Yes it looks like a
sphere
```
#### Height Map Generation on Planes

#### Acceptance

#### Requirements

#### Accepted Rejected Comments

```
Does the terrain look
believable? Not the
shaders, colors or
shadows.
Do 2-3 layers of Simplex
noise make realistic
looking heightmaps?
Does 5-7 layers of
Simplex noise take an
acceptable amount of
time to generate?
```
#### Height Map Generation on Planes (Results)

#### Michael

#### Acceptance

#### Requirements

#### Accepted Rejected Comments

```
Does the terrain look
realistic? Not the
shaders, colors, or
shadows.
```
```
✓ It’s not like real life,
because in real life
the terrain should
be flat from space.
For a game it does
look real.
Do 2 - 3 layers of Simplex
noise make realistic
looking heightmaps?
```
##### ✓

```
Does 5 - 7 layers of
Simplex noise take an
```
```
✓ There was not a
huge difference for
```

Page **12** of **46**

```
acceptable amount of
time to generate?
```
```
the time it takes to
generate the layers
from 2- 7
```
#### Andy

#### Acceptance

#### Requirements

#### Accepted Rejected Comments

```
Does the terrain look
realistic? Not the
shaders, colors or
shadows.
```
##### ✓

```
Do 2-3 layers of Simplex
noise make realistic
looking heightmaps?
```
##### ✓

```
Does 5-7 layers of
Simplex noise take an
acceptable amount of
time to generate?
```
##### ✓

#### Vipulan

#### Acceptance

#### Requirements

#### Accepted Rejected Comments

```
Does the terrain look
realistic? Not the
shaders, colors or
shadows.
```
##### ✓

```
Do 2-3 layers of Simplex
noise make realistic
looking heightmaps?
```
##### ✓

```
Does 5-7 layers of
Simplex noise take an
acceptable amount of
time to generate?
```
##### ✓

#### Terry

#### Acceptance

#### Requirements

#### Accepted Rejected Comments

```
Does the terrain look
realistic? Not the
shaders, colors, or
shadows.
```
```
✓ Yes,^ it looks like^
Mountains
```
```
Do 2 - 3 layers of Simplex
noise make realistic
looking heightmaps?
```
```
✓ Yes,^ it makes it like
there are terrain
features
```

Page **13** of **46**

```
Does 5 - 7 layers of
Simplex noise take an
acceptable amount of
time to generate?
```
```
✓ Seems fast^
```
#### Gravity

#### Acceptance

#### Requirements

#### Accepted Rejected Comments

```
Does gravity that controls
the flow of the raindrops
look realistic?
In first person, do the
land masses and
mountains look
believable?
In first person, are the
frames you’re getting
acceptable for gameplay?
```
#### Gravity (Results)

#### Michael

#### Acceptance

#### Requirements

#### Accepted Rejected Comments

```
Does gravity that controls
the flow of the raindrops
look realistic?
```
```
✓ The player isn’t
affected by gravity,
but the rain flow
does look real.
In first person, do the
land masses and
mountains look
believable?
```
```
✓ Not like real life but
good for a game.
```
```
In first person, are the
frames you’re getting
acceptable for gameplay?
```
```
✓ There were random
intervals where the
framerate dropped
but it didn’t last that
long.
```
#### Andy

#### Acceptance

#### Requirements

#### Accepted Rejected Comments

```
Does gravity that controls
the flow of the raindrops
look realistic?
```
##### ✓


Page **14** of **46**

```
In first person, do the
land masses and
mountains look
believable?
```
(^) ✓ Mountains could be
smoother
In first person, are the
frames you’re getting
acceptable for gameplay?

##### ✓

#### Vipulan

#### Acceptance

#### Requirements

#### Accepted Rejected Comments

```
Does gravity that controls
the flow of the raindrops
look realistic?
```
##### ✓

```
In first person, do the
land masses and
mountains look
believable?
```
##### ✓

```
In first person, are the
frames you’re getting
acceptable for gameplay?
```
##### ✓

#### Terry

#### Acceptance

#### Requirements

#### Accepted Rejected Comments

```
Does gravity that controls
the flow of the raindrops
look realistic?
```
```
✓ Yes,^ it follows^
the path of gravity
```
```
In first person, do the
land masses and
mountains look
believable?
```
```
✓ Yes,^ it looks
believable
```
```
In first person, are the
frames you’re getting
acceptable for gameplay?
```
```
✓ Yes 120+ fps is
acceptable
```
#### Hydraulic Erosion

#### Acceptance

#### Requirements

#### Accepted Rejected Comments

```
Does the effect of
hydraulic erosion have a
significant decrease in
frames?
```

Page **15** of **46**

```
Are you able to see a
significant change in
terrain after the erosion?
Showing a before and
after picture to find the
differences.
```
#### Hydraulic Erosion (Results)

#### Michael

#### Acceptance

#### Requirements

#### Accepted Rejected Comments

```
Does the effect of
hydraulic erosion have a
significant decrease in
frames?
```
```
✓ There were random
intervals where the
framerate dropped
but it didn’t last that
long.
Are you able to see a
significant change in
terrain after the erosion?
Showing a before and
after picture to find the
differences.
```
```
✓ Yes, a bit too much
on the lower
subdivision counts.
It does look the best
on 5 and 6
subdivisions.
```
#### Andy

#### Acceptance

#### Requirements

#### Accepted Rejected Comments

```
Does the effect of
hydraulic erosion have a
significant decrease in
frames?
```
(^) ✓ 5 raindrops look
choppy. 2 raindrops
look fine
Are you able to see a
significant change in
terrain after the erosion?
Showing a before and
after picture to find the
differences.

##### ✓

#### Vipulan

#### Acceptance

#### Requirements

#### Accepted Rejected Comments

```
Does the effect of
hydraulic erosion have a
```
(^) ✓ 5 is laggy at times
but 2 is constantly
good


Page **16** of **46**

```
significant decrease in
frames?
Are you able to see a
significant change in
terrain after the erosion?
Showing a before and
after picture to find the
differences.
```
##### ✓

#### Terry

#### Acceptance

#### Requirements

#### Accepted Rejected Comments

```
Does the effect of
hydraulic erosion have a
significant decrease in
frames?
```
```
✓ Yes,^ it does with 5
raindrops drops
down to 40fps
```
```
Are you able to see a
significant change in
terrain after the erosion?
Showing a before and
after picture to find the
differences.
```
```
✓ Yes,^ one of them is
massively smooth
```

Page **17** of **46**

### Collection of Planets created by Testers.................................................................................................

#### Gg Son - Andy

_https://youtu.be/_zYkqud4o2I_

#### Kanem – Vipulan

_https://youtu.be/3A0UcqgsqS_


Page **18** of **46**

#### Aunty Earth – Terry

_https://youtu.be/MA_4Gu1iCK_

## 6. Methodology

### Technologies

#### I will be using Unity without any external libraries for this. Unity will handle the procedural

#### generation, hydraulic erosion and gravity which will all be coded in C#. I will only be using basic

#### shaders/textures that are already in unity and will most likely not make any extra assets. Unity

#### has a built-in way to generate Perlin Noise textures, so I will be using that to generate my

#### heightmaps.

#### If I do need to create any assets or objects, I will be using Blender, Photoshop and PaintTool Sai.


Page **19** of **46**

### Approach

#### My test plan requires me to make ad hoc changes at each milestone by relying on user input

#### and performance testing. For this reason, I will be using an agile approach.

#### After getting user feedback, I will go back and make any changes I need to and review the notes

#### that I received and keep them in mind for future features. I will work one milestone at a time,

#### get them to be functional, do testing, get feedback, apply the feedback, review the feedback

#### and move on to the next milestone and repeat the process.

#### Major Milestones:

#### 1. Geodesic Polyhedron Generation

#### 2. Height Map Generation on Planes

#### 3. Apply Heightmaps to Sphere Faces

#### 4. Simulate Gravity on Planets/1st Person Controls

#### 5. Particle based Erosion on Heightmap on Plane

#### 6. Particle Based Erosion on Heightmaps on Sphere Faces

#### 7. Final optimization

## 7. System/Software Architecture Diagram

#### I will start off with a grid size for each face of the “sphere” and scale the sphere based off the

#### radius.

#### After that I will apply gravity to the sphere, then generate heightmaps to each of the faces of

#### the “sphere”. I will then apply textures to the planet and set the colors based off the height to

#### distinguish between higher and lower points of the planet. Finally, I will apply hydraulic erosion

#### to the planet, and it will be complete.


Page **20** of **46**

#### Inertia


Page **21** of **46**

#### Carry Capacity

#### Deposition Speed


Page **22** of **46**

#### Erosion Speed

#### Evaporation Speed


Page **23** of **46**

#### Erosion Radius

## 8. Innovation

### Hydraulic Erosion

#### The innovation in my project comes from hydraulic erosion. As I mentioned before, hydraulic

#### erosion is a new concept being used in tandem with procedural terrain generation. It is quite

#### complex, so to assist me I will be using the algorithm mentioned in the department of

#### informatics thesis as it is well documented and easy to understand. Some worries I have is that

#### there may be issues implementing the algorithm to a spherical world but will not know for sure

#### until I get there. Hydraulic erosion on planes has been done to death, however the innovative

#### part will be applying this to a spherical world.

#### I would like to have erosion happen in real-time as a player is on the planet and by the time

#### they leave the planet, it will have changed how it looks due to the erosion. This would mean

#### that when they first arrive, the planet is raining while the erosion is happening. After they have

#### solved the problem the rain will clear and stop the erosion, but whatever erosion happened will

#### stay. To have this working, I will need a trigger to enable and disable the erosion if it does not

#### stop naturally. I will also have to make sure the erosion is slow enough to notice but not so fast

#### that it ends before the player has time to explore the planet. Again, I would like to note I will

#### not be creating a game for this, just to make sure these features will work as intended for a

#### game I will work on in the future.


Page **24** of **46**

### Hydraulic Erosion (Results)

#### I implemented the hydraulic erosion by adapting the concepts from the department of

#### informatics thesis and implanting them in a way to work with a 3d space. Originally the

#### intention of the thesis was for 2d planes, so the water flow path generation did not work. To

#### solve this, I generated a user input number of random points above and around the sphere.

#### This is pre-generated at the start at runtime, so less work needs to be done during the update

#### loop of the program. After these points are generated and the planet has been built, the user

#### can press a button to begin erosion. Once this happens, depending on the limit of how many

#### raindrops can exist at a certain time, they are dropped onto the planet. These raindrops use an

#### implementation of the Newtons Law of Universal Gravity to flow down the terrain of the

#### planet.

#### Each raindrop has a few variables assigned to them that keep track of its condition. If a raindrop

#### has very low momentum and has lasted for over 1 second or reached an ocean, then it should

#### be evaporated leaving whatever sediment it has picked up over time. A raindrop has a cap on

#### how much sediment it can hold as well, so if it does reach a cap then it won’t be picking up

#### anymore as it travels across the land. However, it does have a chance to drop some off as it is

#### travelling if it slows down, even if it were to speed up again in the future. The sediment also has

#### a 50 percent chance of not picking up or ignoring sediment from a terrain if it is not full. The

#### erosion is done by removing portions from the terrain’s height as it passes by and adds the

#### height taken to be tracked on the raindrop. To drop off the sediment, I had a portion of all the

#### added-up values of the terrain a raindrop had picked up added onto the height of the nearest

#### vertices. The values I set for the sediment dissolution, sediment cap, sediment drop rate and

#### gravity/inertia are done with the intention of using them for planets that were created with 5

#### or 6 subdivisions. However, to showcase the effect of the erosion I have shown how they look

#### on all the subdivision levels below.

#### Before and After - 0 Subdivisions


Page **25** of **46**

#### Before and After - 1 Subdivision

#### Before and After - 2 Subdivisions

#### Before and After - 3 Subdivisions


Page **26** of **46**

#### Before and After - 4 Subdivisions

#### Before and After - 5 Subdivisions

#### Before and After - 6 Subdivisions


Page **27** of **46**

## 9. Complexity

#### The complexity of this project comes in a few ways.

### Geodesic Polyhedron Generation

### Geodesic Polyhedron Generation

#### I will be working on an algorithm to create geodesic polyhedrons instead of using the Unity

#### sphere to create the planet's base. This is so that I will have an easier time understanding how

#### it works and customizing it.

### Hydraulic Erosion

#### The other complex part of this project is using hydraulic erosion on a spherical world. I will be

#### creating the planet's heightmap using Perlin noise. Then applying the hydraulic erosion to the

#### planets afterwards using the algorithm mentioned in 1.3.

#### I will not be using any external libraries for this project and be implementing the algorithms

#### myself. I will not be creating a game as I believe it is out of scope due to time constraints.

#### Eventually, I can see myself adopting this project for a game I have in mind in the future.

## 10. Technical Challenges

### Geodesic Polyhedron Generation

#### I have never had to generate vertices and create shapes out of them on Unity before. However,

#### I do have some experience with this in OpenGL, so I will be basing my generation on what I

#### have learned in OpenGL. Another problem I may run into is deciding on which type of geodesic

#### polyhedron would be the best to use or to just go with a cube sphere.

(^2)
(^2) Reference _Cube Sphere, a Unity C# Tutorial_ for image and implentation


Page **28** of **46**

### Geodesic Polyhedron Generation (Results)

#### For the geodesic polyhedron generation, I first started working on implementing a way to

#### generate vertices on Unity and draw triangles to connect them. Then eventually once I figured

#### out how to generate triangles, I worked on generating them in pairs to form squares. Once I got

#### the hang of generating 2d rectangles using the squares, I moved on to generating a 3d

#### rectangular prism using what I learned from generating a rectangle composed of squares which

#### are composed of triangles.

#### Vertices generation

_https://youtu.be/z_WWQRG6O8w_


Page **29** of **46**

#### Drawing Triangles................................................................................................................................

_https://youtu.be/TOD76rDKi9s_

#### Creating a Rectangle by Drawing Squares

_https://youtu.be/wBx18dEgLcA_


Page **30** of **46**

#### Creating a Rectangular Prism

_https://youtu.be/g-s0Ljsdv24_

#### Subdivision

#### After understanding the basics of shape generation in Unity, I moved on to generate the

#### sphere. I started off with generating an octahedron following Flick Jasper’s^3 example. I added a

#### slider to subdivide the octahedron which allowed for it to have more vertices to manipulate.

#### Vertices increased quite quickly per subdivision setting, as a result I had to limit the number of

#### subdivisions to a maximum of 65,799 vertices. The subdivision happens by replacing a single

#### triangle with 4 triangles. The constraint is since Unity uses 16-bit integers to index mesh data so

#### it could not be larger than the 6 subdivisions I had. The subdivisions with their vertices and

#### triangle count are shown below as well as a demonstration of the subdivision.

#### 1. 32 triangles, 27 vertices

#### 2. 128 triangles, 79 vertices

#### 3. 512 triangles, 279 vertices

#### 4. 2,048 triangles, 1,063 vertices

#### 5. 8,192 triangles, 4,167 vertices

#### 6. 32,768 triangles, 16,519 vertices

#### 7. 131,072 triangles, 65,799 vertices

(^3) See Flick, Jasper. “Creating an Octahedron Sphere in Unity.”


Page **31** of **46**

```
https://youtu.be/je74_trLTro
```
### Height Map Generation

#### I have had prior experience generating height maps, despite that, I have never tried to make

#### one on a sphere before. I have seen a few videos and it does not look too dissimilar even so, I

#### still think it has the potential to take up a lot of my time.

### Height Map Generation (Results)

#### Height map generation was deceivingly difficult on the sphere. I had prior experience on plans

#### so I thought the concept would translate well, however in practice it was anything but. My first

#### attempt was a using an algorithm I made myself and it was a mess. I did not have very much

#### control over the height, granularity, or consistency which resulted in the shape not looking

#### anything like a planet.


Page **32** of **46**

#### First attempt of height map generation

#### https://youtu.be/qJS9bSyyp8c

#### I attempted to fix this by overlapping the generated terrain with a sphere on top to represent

#### the water. This made shading quite easy as I had a way to distinguish the colors of the ocean

#### and land. Although this did work, the terrain was not very detailed, and I did not have much

#### control over the shape.


Page **33** of **46**

#### Overlapping a sphere to represent the ocean

https://youtu.be/BmLH-ZQPcuY

#### After failing with this algorithm, I moved on to find other solutions that people had developed. I

#### stumbled across a Perlin noise code snippet on GitHub and attempted to use that to generate

#### the heightmap on the sphere. Although it did work, there were issues with the algorithm when

#### some of the settings were pushed too far.


Page **34** of **46**

#### New Algorithm

_https://www.youtube.com/watch?v=c6uBLGCg3qs_

#### Issues with New Algorithms

_https://youtu.be/iDH5MoXkUgg_


Page **35** of **46**

#### I made changes to the algorithm to fix this error and was able to generate a heightmap exactly

#### like how I imagined it in my concept art. However, as I started working on the erosion, I realized

#### that this would not work. The heightmap was not granular or rough enough for the erosion to

#### work as the top areas were too flat. I moved on to find another algorithm, but this is what I had

#### ended up with at the time. I also was experimenting with shaders to figure out a way to

#### differentiate different height levels.

#### Fixed Algorithm for Heightmap...........................................................................................................

_https://youtu.be/qRt0zWR3zqM_


Page **36** of **46**

#### Experimenting with Shaders

_https://youtu.be/tjXHsXdiw9g_

#### To address the erosion problem, I adjusted the algorithm once again to have a much more

#### varied height level to create mountains and valleys. I also figured out how to get a shader to

#### differentiate between height levels. Although this did work, it did not look very realistic so, I

#### went on to find a new algorithm to implement.


Page **37** of **46**

#### Algorithm with Varying Heights

_https://youtu.be/z3PxfOYhHtI_

#### The algorithm I finally ended up choosing is an open-source simplex noise algorithm which is a

#### part of libnoise-dotnet. This algorithm was perfect as was much simpler and easier to use than

#### the one I was using before. I was quite easily able to implement strength, roughness, and the

#### center of the noise. I then went on to implanting multiple layers of noise to build up more detail

#### in the terrain. As I was building the noise layers, I was having a tough time figuring out how to

#### mask it onto already created noise and set limits to the heights without it looking realistic. I was

#### lucky enough to find a tutorial by Sebastian Lague on YouTube where he had done just that,

#### which helped me out greatly. Using his example, I was able to implement two different types of

#### layered noise, a simple version and a rigid version. The simple noise creates a basic round

#### terrain, then using the rigid filter on top I was able to create more ridge-like pointed shapes to

#### resemble mountains instead of hills.


Page **38** of **46**

#### Masking Problems when Rigid Filter is on Simple Filter

https://youtu.be/U9jLicmCn8Q

https://youtu.be/hMAzMvkGK3A


Page **39** of **46**

#### Finish Product after bugs were fixed

https://youtu.be/AgqQlrHl57

#### Finished Product with Updated Shaders.............................................................................................

https://youtu.be/-E56kF5ZNIg


Page **40** of **46**

### Simulating Gravity on a Planet

#### Simulating gravity might be challenging depending on how I decide to implement it. I have read

#### a few articles, watched a few videos on how it can be implemented and found countless

#### different approaches. After combing through them, I found a gravity system similar to Mario

#### Galaxy to be the most ideal^4. I have found an article explaining how to emulate Mario Galaxy's

#### style so I will most likely be following that.

### Simulating Gravity on a Planet (Results)

#### Looking back, realistically I did not need a complex gravity implementation like the Mario

#### Galaxy one I initially thought of. All I needed was a way for fluids or objects to fall down a

#### planet, travel through its terrain and eventually come to a stop. Quite simple, so I ended up

#### using Newton's Law of universal gravitation in my project. All I had to do was add an attractor

#### script to the planets, then a separate one for the raindrops I generate. I just calculated the

#### gravitational force between the raindrops and the planet, figure out which direction it needs to

#### go to and applied force in that direction until it slows and eventually comes to a stop.

(^4) Reference _Mario Galaxy Physics in Unity – Mike Loscocco_ for detailed implementation


Page **41** of **46**

## 11. Development Schedule and Milestones

As I am working part time, I will not be able to work on Mondays and Fridays, for that reason I have
adjusted my schedule to accommodate for that.

### Week

#### Day Task Hours

```
Sunday Geodesic Polyhedron Algorithm 8
Tuesday Geodesic Polyhedron
Generation
```
##### 8

```
Wednesday Geodesic Polyhedron
Generation
```
##### 8

```
Thursday Geodesic Polyhedron
Generation
```
##### 8

```
Saturday Texture Mapping 8
Total: 40 hours
```
### Week 2 – Milestone: Height Map Generation on Planes (16 Hours)......................................................

#### Day Task Hours

```
Sunday QA Testing 8
Tuesday Applying Changes from Testing 8
Wednesday Review Changes/Apply any
Leftover Changes
```
##### 8

```
Thursday Height Map Generation on
Planes
```
##### 8

```
Saturday Height Map Generation on
Planes
```
##### 8

```
Total: 40 hours
```
### Week 3 – Milestone: Apply Heightmaps to Sphere Faces (24 Hours)

#### Day Task Hours

```
Sunday Apply Heightmaps to Sphere
Faces
```
##### 8

```
Tuesday Apply Heightmaps to Sphere
Faces
```
##### 8

```
Wednesday Apply Heightmaps to Sphere
Faces
```
##### 8

```
Thursday QA Testing 8
Saturday Apply Changes from Testing 8
Total: 40 hours
```
### Week 4 – Milestone: Simulate Gravity and 1st Person Controls (24 Hours)

#### Day Task Hours

```
Sunday Add 1st Person Controls 8
Tuesday Simulate Gravity on Planets 8
```

Page **42** of **46**

```
Wednesday Simulate Gravity on Planets 8
Thursday QA Testing 8
Saturday Apply Changes from Testing 8
Total: 40 hours
```
### Week

#### Day Task Hours

```
Sunday Applying Textures Based off
Heightmaps
```
##### 8

```
Tuesday Buffer Time 8
Wednesday Buffer Time 8
Thursday Buffer Time 8
Saturday Particle based Erosion on
Heightmap on Plane
```
##### 8

```
Total: 40 hours
```
### Week 6 – Milestone: Particle Based Erosion on Heightmaps on Planes (24 Hours)

#### Day Task Hours

```
Sunday Particle based Erosion on
Heightmap on Plane
```
##### 8

```
Tuesday Particle Based Erosion on
Heightmap on Plane
```
##### 8

```
Wednesday Particle Based Erosion on
Heightmap on Plane
```
##### 8

```
Thursday Particle Based Erosion on
Heightmaps on Sphere Faces
```
##### 8

```
Saturday Particle Based Erosion on
Heightmaps on Sphere Faces
```
##### 8

```
Total: 40 hours
```
### Week 7 – Milestone: Particle Based Erosion on Heightmaps on Sphere Faces (48 Hours)

#### Day Task Hours

```
Sunday Particle Based Erosion on
Heightmaps on Sphere Faces
```
##### 8

```
Tuesday Particle Based Erosion on
Heightmaps on Sphere Faces
```
##### 8

```
Wednesday Particle Based Erosion on
Heightmaps on Sphere Faces
```
##### 8

```
Thursday Particle Based Erosion on
Heightmaps on Sphere Faces
```
##### 8

```
Saturday QA Testing 8
Total: 40 hours
```
### Week 8 – Milestone: Final Optimization (32 Hours)

#### Day Task Hours

```
Sunday Apply Changes from Testing 8
```

Page **43** of **46**

```
Tuesday Optimize Deposition, Inertia,
Carry Capacity and Gravity
```
##### 8

```
Wednesday Make hydraulic erosion run in
real time
```
##### 8

```
Thursday Optimize Erosion for
Performance
```
##### 8

```
Saturday Optimize Erosion for
Performance
```
##### 8

```
Total: 40 hours
```
### Week 9

#### Day Task Hours

```
Sunday QA Testing 8
Tuesday Bug Fixing 8
Wednesday Bug Fixing 8
Thursday Set up scenes for presentation 8
Saturday Set up scenes for presentation 8
Total: 40 hours
```
### Week 10

#### Day Task Hours

```
Sunday Buffer Time 8
Tuesday Buffer Time 8
Wednesday Buffer Time 8
Thursday Buffer Time 8
Saturday Buffer Time 8
Total: 40 hours
```
### Week 11

#### Day Task Hours

```
Sunday Buffer Time 8
Tuesday Buffer Time 8
Wednesday Buffer Time 8
Thursday Buffer Time 8
Saturday Buffer Time 8
Total: 40 hours
```
```
Grand Total: 360-440 Hours
```
## 12. Deliverables

At the end of the project my deliverables will be:

- Project Source Code
- Project Report
- Functional, QA and Stress Test Results


Page **44** of **46**

## 13. Conclusion and Expertise Development

#### The main goal of this project is for me to improve on procedural generation. I have done

#### procedural generation before, but very unoptimized and got exponentially slower if players

#### moved too quickly. I wanted to learn some better methods to implement it throughout this

#### project.

#### The project will also help me learn how to dynamically generate vertices and shapes and apply

#### textures to them in based off height in Unity. Once the project is done, I would want to use the

#### code for a game I am planning on developing in the future. Another skill I think I will find useful

#### will be looking at research from others and applying their algorithms for myself. I have not ever

#### had to do this before, but I can see how valuable a skill it will be to develop in the industry.

## 14. References

1. Beyer, Hans. “Implementation of a Method for Hydraulic Erosion.” Firespark.De, 15 Nov. 2015,
    https://www.firespark.de/resources/downloads/implementation%20of%20a%20methode%20fo
    r%20hydraulic%20erosion.pdf.
2. Flick, Jasper. “Creating an Octahedron Sphere in Unity.” BinPress, 2015,
    https://www.binpress.com/creating-octahedron-sphere-unity/.
3. ---. “Cube Sphere, a Unity C# Tutorial.” Catlike Coding, Catlike Coding, 2015,
    https://catlikecoding.com/unity/tutorials/cube-sphere/.
4. “Interactive Terrain Modeling Using Hydraulic Erosion.” Exppad, The Eurographics Association,
    2008,
    https://data.exppad.com/public/papers/Interactive%20Terrain%20Modeling%20Using%20Hydr
    aulic%20Erosion.pdf.
5. Kahler, Andreas. “Creating an Icosphere Mesh in Code.” Catch 22 - Andreas Kahler’s Blog, 20
    June 2009, [http://blog.andreaskahler.com/2009/06/creating-icosphere-mesh-in-code.html.](http://blog.andreaskahler.com/2009/06/creating-icosphere-mesh-in-code.html.)
6. Lague, Sebastian. Coding Adventure: Hydraulic Erosion. YouTube, 28 Feb. 2019,
    https://www.youtube.com/watch?v=eaXk97ujbPQ.
7. Lague, Sebastian. Procedural Planet Noise. Github, 23 Aug., 2018
    https://github.com/SebLague/Procedural-
    Planets/blob/master/Procedural%20Planet%20Noise/Noise.cs


Page **45** of **46**

8. Loscocco, Mike. “Mario Galaxy Physics in Unity – Mike Loscocco.” Mikeloscocco,
    https://www.facebook.com/WordPresscom, 13 Oct. 2015,
    https://mikeloscocco.wordpress.com/2015/10/13/mario-galaxy-physics-in-unity/.
9. Šťava, Ondrej. Interactive Terrain Modeling Using Hydraulic Erosion. CZECH TECHNICAL
    UNIVERSITY IN PRAGUE, 2008, pp. 30–39.
10. Volynskov, Alexey. “Water Erosion on Heightmap Terrain.” Ranmantaru Games, Ranmantaru
    Games, 8 Nov. 2011, [http://ranmantaru.com/blog/2011/10/08/water-erosion-on-heightmap-](http://ranmantaru.com/blog/2011/10/08/water-erosion-on-heightmap-)
    terrain/.

## 15. Change Log

Aug 30, 2020

Added:

- Added results information

Nov 11, 2020

Added:

- Deliverables
- Milestones

Updated:

- Testing Plan
- Methodology
- System/Software Architecture Diagram
- Scope and Depth
- Removed contractions

Oct 28, 20 20

Added:

- Test Plan
- Methodology


Page **46** of **46**

- System/Software Architecture Diagram

Updated:

Oct 16, 2020

Added:

- Scope and Depth
- Conclusion and Expertise

Updated:

- References/Works Cited
- Properly formatted everything

#### Sept 30, 2020

#### Changed: Updated Project Description

#### ● Explained how algorithm will be demonstrated

#### ● Clarified if I will be using libraries or not

#### ● Rephrased


