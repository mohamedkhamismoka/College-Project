

$(document).ready(function () {
    $(".add").click(function () {
        var crs = $("#course").val();
        var degree = $("#degree").val();
        var year = $("#year").val();
        var term = $("#term").val();
        var stid = $("#stid").val();
        if (crs == 0 || year < 1 || year > 4 || term < 1 || term > 2) {
            alert("Please,enter valid data");
        } else {
            $.ajax({
                method: "Post",
                url: "/StudentCourse/Add",
                data: { std_id: stid, crsid: crs, degree: degree, year: year, term: term },
                success: function (res) {
                    if (res.state == 1) {
                        $(".degrees tbody").append("<tr> <td>" + stid + "</td> <td>" + crs + "</td> <td>" + res.name + "</td><td>" + degree + "</td> <td> <button class='btn btn-primary upd'><i class='mdi mdi-pencil-box'></i></button></td><td>  <button class='btn btn-danger del'><i class='mdi mdi-eraser'></i></button></td>")

                    } else {
                        alert("Please,enter valid data");
                    }
                }
            }
            )
        }
    })
    


    $(document).on("click", ".upd", (function () {
      
            
        var term;
        var year;
        var degree;
        var std = this.parentElement.parentElement.children[0].innerHTML;
        var data = this.parentElement.parentElement;
        var crs = this.parentElement.parentElement.children[1].innerHTML;

    
        while (true) {

             degree = prompt("Enter New Degree");
            if (degree.length != 0 && !isNaN(degree) && degree != null) {

                break;

            } 
        }
        while (true) {

             year = parseInt(prompt("Enter New Year"))
            if (year.length != 0 && !isNaN(year) && year != null) {

                break;

            }
        }
        while (true) {

             term = parseInt(prompt("Enter New term"))
            if (term.length != 0 && !isNaN(term) && term != null) {

                break;

            }
        }
    
        

        if (crs == 0 || year < 1 || year > 4 || term < 1 || term > 2 ) {
            alert("Please,enter valid data");
        } else {
            $.ajax({
                method: "Post",
                url: "/StudentCourse/update",
                data: { std_id: std, crsid: crs, degree: degree, year: year, term: term },
                success: function (res) {
                    if (res.state == 1) {
                        data.remove();
                        $(".degrees tbody").append("<tr><td>" + std + "</td><td>" + crs + "</td> <td>" + res.name + "</td><td>" + degree + "</td> <td> <button class='btn btn-primary upd'><i class='mdi mdi-pencil-box'></i></button></td><td>  <button class='btn btn-danger del'><i class='mdi mdi-eraser'></i></button></td>")
                    } else {
                        alert("Please,enter valid data");
                    }
                }
            })
        }
    })
    )


    $(document).on("click", ".del", (function () {
     
        var std = this.parentElement.parentElement.children[0].innerHTML;
        var data = this.parentElement.parentElement;
        var crs = this.parentElement.parentElement.children[1].innerHTML;


        $.ajax({
            method: "Post",
            url: "/StudentCourse/Delete",
            data: { std_id: std, crsid: crs },
            success: function (res) {
                if (res.state == 1) {
                    data.remove();
                    alert("deleted successfully");

                } else {
                    alert("Please,enter valid data");
                }
            }
        })

    }))
})
