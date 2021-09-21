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