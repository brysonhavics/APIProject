**Player Put**
----
  Updating a player in the databases based off of the player id.

* **URL**

  {Base Url}/api/Player

* **Method:**
  
  Put

  
*  **URL Params**

   **Required:**

* **Data Params**

   PlayerId: Int\
   Name: string\
   Number: Int\
   Position: Int\
   TeamId: Int\
   InternationalId: Int\

* **Success Response:**
  
  * **Code:** 200 <br />
 
* **Error Response:**

* **Code:**\
    * 400 BadRequest <br />
    **Content:** `{ error : Model State }`

  OR

  * **Code:** 500 Internal Server Error 

* **Notes:**

  The PlayerId only specifies what player you want to change based off of Id. You can not edit this number. So, enter the Id of the player you want to change in that body parameter. 