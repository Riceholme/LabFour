//GET Hämta alla personer i systemet
http://localhost:5000/api/Person

//GET Hämta alla intressen för specifik person
http://localhost:5000/api/Person/1/interests

//GET Hämta alla länkar för specifik person
http://localhost:5000/api/Person/1/links

//POST Lägga till nytt intresse med relation av särskild befintlig person
http://localhost:5000/api/Interest
{
        "title": "Guitar",
        "description": "Acoustic",
        "webSites": null,
        "personId": 1
        
    }

//POST Lägga till ny Website med relation till särskilt befintligt intresse och person
http://localhost:5000/api/website
{
        "link": "https://dota2.fandom.com/wiki/Dota_2_Wiki",
        "description": "Dota 2 Website",
        "interestId": 1
        
}
