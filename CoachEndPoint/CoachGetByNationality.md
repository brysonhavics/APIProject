**Coach GetByNationality**
----
  Finds Coaches by where they are from

* **URL**

  {Base Url}/api/Coach/Nationality/{nationality}

* **Method:**

  Get


* **URL Params**

   {nationality} = [string]
   
 **Required:**

   {nationality} = [string]

* **Data Params**

   

* **Success Response:**

   * **Code:** 200 <br />

* **Error Response:**

  * **Code:** 400 BadRequest <br />
    **Content** `{ error : Model State }`

  OR

  * **Code:** 500 Internal Server Error

* **Notes:**

    Can get a little convoluted/pointless if you make too many coaches of the same nationality