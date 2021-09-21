**Transfer Post**
----
  Adding a single transfer to the transfer table

* **URL**

  {Base Url}/api/Transfer

* **Method:**
  
  Post

  
*  **URL Params**

    None

   **Required:**
    
    None

* **Data Params**

   Fee: Double\
   NewTeam: int\
   PlayerId: int\

* **Success Response:**
  
  * **Code:** 200 <br />
 
* **Error Response:**

  * **Code:** 400 BadRequest <br />
    **Content:** `{ error : Model State }`

  OR

  * **Code:** 500 Internal Server Error 

* **Notes:**

  Make sure you have data stored in the League, Team, International, and players tables before posting, input validation coming soon.  