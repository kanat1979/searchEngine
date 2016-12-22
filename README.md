Before application assembly, add Api.key, received from Google, in a string constant "ApiKey" of Google Search action in a controller Home.
The application is performed in Asp.net. I used Google Apis as a search.
By creating the object CustomsSearchService, I create a new search service. 

When creating list request, the service metadatas are created. Also I indicate the ID of search system in this object. 

Then the search in a specified pattern is performed by running the execute method of the object of list request. 
The search results are sent to the view.
