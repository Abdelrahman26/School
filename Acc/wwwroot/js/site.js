// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
let Crs_parent = document.getElementById('Crs');
let add_more_field = document.getElementById('add_more_field');

add_more_field.onclick = function () {
    let break_field = document.createElement('br')
    Crs_parent.appendChild(break_field)

    let new_field = document.createElement('input');
    //new_field.setAttribute('asp-for', "courseWriteDtos[0].CrsId")
    new_field.setAttribute('name', "courseWriteDtos_1__CrsId")
    //new_field.setAttribute("asp-items", "ViewBag.courses")
    new_field.setAttribute('placeholder', 'Select Course');

    let new_field2 = document.createElement('input')
    new_field2.setAttribute("name", "courseWriteDtos_1__Crs_length")
    new_field2.setAttribute('placeholder', 'Crs_length');

    let new_field3 = document.createElement('input');
    new_field3.setAttribute("name", "courseWriteDtos_1__StartTime")
    new_field3.setAttribute('placeholder', 'StartTime');

    let new_field4 = document.createElement('input');
    new_field4.setAttribute("name", "courseWriteDtos_1__TeacherId")
    new_field4.setAttribute('placeholder', 'TeacherId');

    Crs_parent.appendChild(new_field);
    Crs_parent.appendChild(new_field2);
    Crs_parent.appendChild(new_field3);
    Crs_parent.appendChild(new_field4);
    
    console.log(Crs_parent);
}
