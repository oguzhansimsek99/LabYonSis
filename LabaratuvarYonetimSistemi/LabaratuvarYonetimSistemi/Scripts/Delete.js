function DeleteRow(id) {
    Swal.fire({
        title: 'Emin misiniz?',
        text: " Bunu Sildiğinizde geri döndüremezsiniz!",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Sil',
        cancelButtonText: 'İptal'
    }).then((result) => {
        if (result.value) {
            var x = document.getElementById(id).href;
            $.ajax({
                url: x,
                type: 'POST',
                dataType: 'json',
                data: { 'id': id },
                success: function (data) {
                    if (data == "1") {
                       
                        Swal.fire(
                            'Silindi!',
                            'Silmek istenilen başarıyla silindi.',
                            'success'
                        )
                        //console.log($('#' + id).parent('div').parent('div'));
                        //console.log($('#' + id).parent('li').parent('ul').parent('div').parent('div'));
                        //$('#' + id).parent('div').parent('div').remove();
                        $('#' + id).parent('div').parent('button').parent('div').remove();
                    }
                    else {
                        Swal.fire({
                            icon: 'error',
                            title: 'Hata...',
                            text: data,
                        })
                    }

                }
            });

        }
    })

}