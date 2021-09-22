# APIProject Soccer

## Resources
[Planning Document](https://docs.google.com/document/d/1WE3OF6A9noFcLT5HsK31hMWVEH_l-EnV2SKjTlBMiJk/edit?usp=sharing)

[Miro Board](https://miro.com/app/board/o9J_lxJyUuo=/)

## Contributers
> Bryson Havics
> ---
> Jack McNeil
> ---
> Chris Crowley
> ---
> John Mai
> ---

This program allows you to follow your favorite Teams, Players, and Leagues across the world. So far, the program allows the user to create and manage Leagues, Teams, Players, International Teams/Leagues, and Coaches. We've been working on adding functionality to allow the user to sim games and manage transactions across the leagues! The main stretch goal we are hoping to accomplish is to add real world wins, losses, and draws from real world data.

Right now, to successfully use the program; it's dependent on first creating a league. Once you've got that accomplished you can move on to adding as many teams as you'd like to the league. We recommend sticking to the number of teams you set for the league when you created it. Once you're feeling accomplished enough on the team create front; you can begin to fill up the rosters of the team with the players that are on the team or that you would like to see on your favorite team. You want Neymar on ManU? No problem!


![premier-league-season-preview-liverpool-title](https://user-images.githubusercontent.com/87817555/134224470-652449f8-d8ff-450a-82e9-2c96eaaa4498.jpg)


## End Point Documentation
|     League    |         Team         | International |         Player         |  Transfer |           Coach          |    Game   |
|:-------------:|:--------------------:|:-------------:|:----------------------:|:---------:|:------------------------:|:---------:|
|      [Post](EndPointDocs\LeagueEndPoint\LeaguePost.md)     |         Post         |      Post     |          Post          |    Post   |           Post           |    Post   |
|    [Get All](EndPointDocs\LeagueEndPoint\LeagueGet.md)    |        Get All       |    Get All    |         Get All        |  Get All  |          Get All         |  Get All  |
|   [Get by Id](EndPointDocs\LeagueEndPoint\LeagueGetById.md)   |       Get by Id      |       -       |        Get by Id       | Get by ID |         Get by ID        | Get by Id |
| [Get by Nation](EndPointDocs\LeagueEndPoint\LeagueGetByNation.md) |     Get by League    |       -       | Get Player by Position |     -     | Get Coach By Nationality |     -     |
|       -       | Get By League Sorted |       -       |   Get Player by Team   |     -     |             -            |     -     |
|     [Delete](EndPointDocs\LeagueEndPoint\LeagueDelete.md)    |        Delete        |     Delete    |         Delete         |     -     |             -            |   Delete  |
|      [Put](EndPointDocs\LeagueEndPoint\LeagueUpdate.md)      |          Put         |      Put      |           Put          |     -     |            Put           |     -     |
