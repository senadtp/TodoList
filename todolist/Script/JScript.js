$(document).ready(function () {
            $(".btn").click(function () {
                if ($("#myInput").val() != "") {
                    var eklenilen = $("<li></li>").text($("#myInput").val());
                    var silButonu = $("<span class = kapat >x</span>").click(function () {
                        $(this).parent().remove();

                    });
                    eklenilen.append(silButonu);
                    eklenilen.click(function () {
                        $(this).toggleClass("checked")
                    })
                    $("#myUL").append(eklenilen); /"ul li:first-child"/ /* -->w3 te ul li için verilmiş.*/
                    $("#myInput").val("");
                }
            });
            $('span[name ="kapatbisi"]').click(function () {
                var p = $(this).parent();
                p.remove();
            });
            $("li").click(function () {
                $(this).toggleClass("checked")
            });
        });