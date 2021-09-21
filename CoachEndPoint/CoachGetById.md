**Coach GetById**
----
  Find a coach using their unique Id

* **URL**

  {Base Url}/api/Coach/Id/{id}

* **Method:**

  Get


* **URL Params**

   {id} = [int]
   
 **Required:**

   {id} = [int]

* **Data Params**

   None

* **Success Response:**

   * **Code:** 200 <br />

* **Error Response:**

  * **Code:** 400 BadRequest <br />
    **Content** `{ error : Model State }`

  OR

  * **Code:** 500 Internal Server Error

* **Notes:**

    Helps you find a single coach that you have previously made in this session