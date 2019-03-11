import org.w3c.dom.CanvasRenderingContext2D
import org.w3c.dom.HTMLCanvasElement
import kotlin.browser.document
import kotlin.browser.window

val canvas = document.getElementById("canvas") as HTMLCanvasElement
val renderer = canvas.getContext("2d") as CanvasRenderingContext2D

fun resizeProcedure() {
	canvas.width = window.innerWidth
	canvas.height = window.innerHeight
}
