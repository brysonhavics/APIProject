**Team Post**
----
  Posting a single team to the Database

* **URL**

  {Base Url}/api/Team

* **Method:**
  
  Post

  
*  **URL Params**

    None

   **Required:**
    
    None
   `id=[integer]`

* **Data Params**

   TeamName: string\ (Max Length: 40)
   LeagueId: Int\
   Rank: Int\

* **Success Response:**
  
  * **Code:** 200 <br />
 
* **Error Response:**

  * **Code:** 400 BadRequest <br />
    **Content:** `{ error : Model State }`

  OR

  * **Code:** 500 Internal Server Error 

* **Notes:**

  Make sure you have data stored in the League table before posting, input validation coming soon.  

<br />

  **Team Get**
----
  Getting all the teams from the Database

* **URL**

  {Base Url}/api/Team

* **Method:**
  
  Get

  
*  **URL Params**

    None

   **Required:**
    
    None

* **Data Params**

    None

* **Success Response:**
  
  * **Code:** 200 <br />
 
* **Error Response:**

  * **Code:** None <br />
    **Content:** None

* **Notes:**

  Make sure you have data stored in the Team table before getting or you'll return nothing.  

<br />

  **Team Put**
----
  Updating a single team on the Database

* **URL**

  {Base Url}/api/Team/

* **Method:**
  
  Put

  
*  **URL Params**

    None

   **Required:**
    
    None
   `id=[integer]`

* **Data Params**

    TeamId: Int\
    TeamName: string\
    Rank: Int\
    LeagueId: Int\

* **Success Response:**
  
  * **Code:** 200 <br />
 
* **Error Response:**

  * **Code:** 400 BadRequest <br />
    **Content:** `{ error : Model State }`

  OR

  * **Code:** 500 Internal Server Error 

* **Notes:**

  This will likely used for possible promotion/relegation scenarios and wins/losses moving ranks up

  <br />

**Team Delete**
----
  Deleting a single team to the Database

* **URL**

  {Base Url}/api/Team/Delete

* **Method:**
  
  Delete

  
*  **URL Params**

    id: Int\

   **Required:**
    
    None
   `id=[integer]`

* **Data Params**

* **Success Response:**
  
  * **Code:** 200 <br />
 
* **Error Response:**

  * **Code:** 400 BadRequest <br />
    **Content:** `{ error : Model State }`

  OR

  * **Code:** 500 Internal Server Error 

* **Notes:**

  Make sure you really want to delete this team.

<br />

   **Team Get by League**
----
  Getting all the teams from one specific league

* **URL**

  {Base Url}/api/Team/League/{id}

* **Method:**
  
  Get

  
*  **URL Params**

    id: Int\

   **Required:**
    
    None

* **Data Params**

    None

* **Success Response:**
  
  * **Code:** 200 <br />
 
* **Error Response:**

  * **Code:** None <br />
    **Content:** None

* **Notes:**

  Make sure you have data stored in that League's Team table before getting or you'll return nothing.  

<br />

   **Team Get by League**
----
  Getting all the teams from one specific league

* **URL**

  {Base Url}/api/Team/League/Sorted/{id}

* **Method:**
  
  Get

  
*  **URL Params**

    id: Int\

   **Required:**
    
    None

* **Data Params**

    None

* **Success Response:**
  
  * **Code:** 200 <br />
 
* **Error Response:**

  * **Code:** None <br />
    **Content:** None

* **Notes:**

  Gets all the teams in a league and then displays then by rank.  

<br />

   **Team Get by Id**
----
  Gets a specific team by their id.

* **URL**

  {Base Url}/api/Team/{id}

* **Method:**
  
  Get

  
*  **URL Params**

    id: Int\

   **Required:**
    
    None

* **Data Params**

    None

* **Success Response:**
  
  * **Code:** 200 <br />
 
* **Error Response:**

  * **Code:** None <br />
    **Content:** None

* **Notes:**

    None