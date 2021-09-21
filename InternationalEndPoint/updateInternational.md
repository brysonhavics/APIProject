**Player Post**
----
 Updating a single International Team to the Database

* **URL**

  {Base Url}/api/International

* **Method:**
  
  Update

  
*  **URL Params**

    None

   **Required:**
    
    None
   `id=[integer]`

* **Data Params**
   Coach: sting\
   Ranaking: int\
   Name: string\
   
* **Success Response:**
  
  * **Code:** 200 <br />
 
* **Error Response:**

  * **Code:** 400 BadRequest <br />
    **Content:** `{ error : Model State }`

  OR

  * **Code:** 500 Internal Server Error 

* **Notes:**

  allows user to update international team 