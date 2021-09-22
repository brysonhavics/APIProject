**Player Get**
----
  Getting a single Player from the database form their PlayerId

* **URL**

  {Base Url}api/Player/Team/{id}

* **Method:**
  
  Get

  
*  **URL Params**

    `{id} = [integer]`

   **Required:**

   `id=[integer]`

* **Data Params**

   None

* **Success Response:**
  
  * **Code:** 200 <br />
 
* **Error Response:**

* **Notes:**

  If you request an Id that is not attached to a team than visual studio will throw an error. Input validation coming soon.  