
var row=document.getElementsByClassName("row")[0]

function fillHtml(data){

  data.forEach(element => {
    
row.innerHTML+=`
<div class="card col-3" style="width: 18rem;">
<img src="${element.image.medium}" class="card-img-top" alt="...">
<div class="card-body">
  <h5 class="card-title">${element.name}</h5>
  <p class="card-text">${element.runtime}</p>
  <a href="details.html?id=${element.id}" class="btn btn-primary">Check</a>
</div>
</div>

`

  });

}


fetch("https://api.tvmaze.com/shows").then(response=>response.json()).then(data=>fillHtml(data))



















// var ol=document.getElementById("users")


// fetch("https://jsonaceholder.typicode.com/users")
// .then(response=>response.json())
// .then(data=>{

//     for (let i = 0; i < data.length; i++) {
        
//         if(data[i].name.includes("a")){
//             ol.innerHTML+=`<li>${data[i].name} email:${data[i].email}</li>`
//         }
       
        
//     }
// }).catch(ex=>console.log(ex))





// $.ajax({

//     method:"GET",
//     url:"https://jsonplaceholder.typicode.com/users"
// }).done(data=>{
//     for (let i = 0; i < data.length; i++) {
        
//                 if(data[i].name.includes("a")){
//                     ol.innerHTML+=`<li>${data[i].name} email:${data[i].email}</li>`
//                 }
               
                
//             }

// })