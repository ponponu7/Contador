//obj_contador - create:
window_set_position(18,22)
global.push = ord("1")
global.conteo = 0;


//obj_contador - step:
if keyboard_check_direct(global.push){
	   if (!key_pressed_this_frame) { // Realiza acciones solo cuando la tecla es presionada por primera vez en este frame
        global.conteo += 1;
        key_pressed_this_frame = true; // Marca que la tecla ha sido detectada en este frame
    }
} else {
    // Restablece el estado para la próxima verificación en el siguiente frame
    key_pressed_this_frame = false;
}

//obj_contador - draw:
draw_set_color(c_white);
draw_set_font(Kavak); //importe la fuente de Kavak a GMK por lo cual aca la puedo nombrar
draw_set_halign(fa_center); // Alineación horizontal centrada
draw_set_valign(fa_middle); // Alineación vertical centrada
draw_text(view_xview[0]+90,view_yview[0]+60,"KAVAK: " + string(global.conteo));


//obj_mas - izquierdo pulsado:
global.conteo += 1;


//obj_menos - izquierdo pulsado:
global.conteo -= 1;


//obj_restart - izquierdo pulsado:
global.conteo = 0


//obj_teclado - create:
cambio = false
image_index = 0


//obj_teclado - izquierdo pulsado:
if (position_meeting(mouse_x, mouse_y, self))
{
	cambio = true
	image_index = 1
}
else
{
	cambio = false
	image_index = 0
}


//obj_teclado - Pulsacion de tecla-cualquiera:
if (cambio)
{
global.push = keyboard_key;
image_index = 0;
cambio = false;
}



//Room 1
https://www.tumblr.com/joel2544/759186460074295296/contador-kavak-room-1?source=share