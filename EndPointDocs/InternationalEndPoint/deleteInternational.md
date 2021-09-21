**Player Post**
----
Delete a single International Team to the Database

* **URL**

  {Base Url}/api/Player

* **Method:**
  
  delete

  
*  **URL Params**

    None

   **Required:**
    
    None
   `id=[integer]`

* **Data Params**

  Coach: string\
   Ranking: int\
   Name: string\
   

* **Success Response:**
  
  * **Code:** 200 <br />
 
* **Error Response:**

  * **Code:** 400 BadRequest <br />
    **Content:** `{ error : Model State }`

  OR

  * **Code:** 500 Internal Server Error 

* **Notes:**

  allow user to delete international team  