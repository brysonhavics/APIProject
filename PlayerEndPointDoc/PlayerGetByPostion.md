**Player Get**
----
  Getting a list of players from the database given an entered position. 

* **URL**

  {Base Url}/api/Player/{position}

* **Method:**
  
  Get

  
*  **URL Params**

    (Postion Key\
    0 = Forward\
    1 = Midfield\
    2 = Defender\
    3 = Goalkeeper)\
    `{position} = [int]`
    

   **Required:**

   `position=[int]`

* **Data Params**

   None

* **Success Response:**
  
  * **Code:** 200 <br />
 
* **Error Response:**

* **Notes:**

  If you request a position that is not attached to a player than visual studio will throw an error. Input validation coming soon.  