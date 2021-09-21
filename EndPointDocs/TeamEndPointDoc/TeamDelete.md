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
