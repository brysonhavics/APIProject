**Player Post**
----
  Posting a single international team to the Database

* **URL**

  {Base Url}/api/International

* **Method:**
  
  Post

  
*  **URL Params**

    None

   **Required:**
    
    None
   `id=[integer]`

* **Data Params**

   Coach: string\
   Ranking: int\
   Name; string\

* **Success Response:**
  
  * **Code:** 200 <br />
 
* **Error Response:**

  * **Code:** 400 BadRequest <br />
    **Content:** `{ error : Model State }`

  OR

  * **Code:** 500 Internal Server Error 

* **Notes:**

 allows user to post international team