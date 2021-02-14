# montecarlo-blazorapp

A Client Side Blazor App

Monte Carlo Simulations of Investment Portfolios

Goal of project
---------------
Create a web app that lets a user create an investment portfolio based on asset classes and
run monte carlo simulations to see expected returns and account balance over time given starting 
balance and W/D's per year

To start everything will be done client side and investment categories will be hard coded *add custimization later


User Inputs
-----------------
Initial Portfolio Amount
Annual Withdrawel Amount
Simulation Time Period
Rebalancing - None, Annual or Semi-Annual
Asset Allocation by class
    Dynamic List with dropdown selection and text input for percentage allocated
Number of simulations to run - will have upper limit

Business Logic
--------------
Runs monte carlo simulation according to inputs
Outputs outcome to screen in table format, and possibly some nice graphs or user dashboard style
Potentially could let user save multiple simulations for comparison


Future Goals and Ideas
---------
Could become part of a more comprehensive financial planning app
If can find info for individual funds via api, let user select individual investments instead of asset classes
Let user export outcomes to file? Or save to remote database
