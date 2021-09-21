**League Update**
----
   Updates a League based on the LeagueId

* **URL**

  {Base Url}/api/League

* **Method:**

  Put


* **URL Params**

   None

 **Required:**

   None

* **Data Params**

   LeagueId: Int
   Name: String
   Nation: String
   NumberOfTeams: Int

* **Success Response:**

   * **Code:** 200 <br />

* **Error Response:**

  * **Code:** 400 BadRequest <br />
    **Content** `{ error : Model State }`

  OR

  * **Code:** 500 Internal Server Error

* **Notes:**

    Makes sure that the League you are updtaing is the one you are selecting to update and then does the update