**Player Post**
----
  Posting a single player to the Database

* **URL**

  {Base Url}/api/Player

* **Method:**
  
  Post

  
*  **URL Params**

    None

   **Required:**
    
    None
   `id=[integer]`

* **Data Params**

   Name: string\
   Number: Int\
   Position: Int\
   TeamId: Int\
   InternationalId: Int\
   Shooting: Int (0-99)\
   Passing: Int (0-99)\
   Defending: Int (0-99)

* **Success Response:**
  
  * **Code:** 200 <br />
 
* **Error Response:**

  * **Code:** 400 BadRequest <br />
    **Content:** `{ error : Model State }`

  OR

  * **Code:** 500 Internal Server Error 

* **Notes:**

  Make sure you have data stored in the League, Team, and international tables before posting, input validation coming soon.  