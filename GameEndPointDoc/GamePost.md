**Game Post**
----
  Posting a game between teams to the Database

* **URL**

  {Base Url}/api/Game

* **Method:**
  
  Post

  
*  **URL Params**

    None

   **Required:**
    
    None
   `id=[integer]`

* **Data Params**

   HomeId: Int\ 
   AwayId: Int\
   Referee: String\

* **Success Response:**
  
  * **Code:** 200 <br />
 
* **Error Response:**

  * **Code:** 400 BadRequest <br />
    **Content:** `{ error : Model State }`

  OR

  * **Code:** 500 Internal Server Error 

* **Notes:**

  You'll need to have made teams and ideally included players with those teams. HomeId and AwayId are the ids of specific teams.  