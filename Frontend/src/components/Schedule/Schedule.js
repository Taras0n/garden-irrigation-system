import styles from './Schedule.module.scss'; 

export default function Schedule() {
    return (
        <div className={styles.schedule}>
            <h2>Grafik podlewu</h2>
            <form>
                <label htmlFor="watering-time">Czas podlewania:</label>
                <input type="time" id="watering-time" name="watering-time" />
                
                <label htmlFor="watering-days">Dni:</label>
                <select id="watering-days" name="watering-days">
                    <option value="monday">Poniedziałek</option>
                    <option value="tuesday">Wtorek</option>
                    <option value="wednesday">Środa</option>
                    <option value="thursday">Czwartek</option>
                    <option value="friday">Piątek</option>
                    <option value="saturday">Sobota</option>
                    <option value="sunday">Niedziela</option>
                </select>
                
                <button type="submit">Zapisać grafik</button>
            </form>
        </div>
    );
}
