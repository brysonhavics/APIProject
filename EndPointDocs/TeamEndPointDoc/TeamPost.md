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