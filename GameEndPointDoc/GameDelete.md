**Game Delete**
----
  Deleting a single game from the Database

* **URL**

  {Base Url}/api/Game/{id}

* **Method:**
  
  Delete

  
*  **URL Params**

    Id: Int\

   **Required:**
    
    None
   `id=[integer]`

* **Data Params**

* **Success Response:**
  
  * **Code:** 200 <br />
 
* **Error Response:**

  * **Code:** 400 BadRequest <br />
    **Content:** `{ error : Model State }`

* **Notes:**

  Make sure you really want that game deleted.  