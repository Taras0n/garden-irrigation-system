import styles from './Schedule.module.scss'; 

export default function Schedule() {
    return (
        <div className={styles.schedule}>
            <h2>Графік поливу</h2>
            <form>
                <label htmlFor="watering-time">Час поливу:</label>
                <input type="time" id="watering-time" name="watering-time" />
                
                <label htmlFor="watering-days">Дні:</label>
                <select id="watering-days" name="watering-days" multiple>
                    <option value="monday">Понеділок</option>
                    <option value="tuesday">Вівторок</option>
                    <option value="wednesday">Середа</option>
                    <option value="thursday">Четвер</option>
                    <option value="friday">П'ятниця</option>
                    <option value="saturday">Субота</option>
                    <option value="sunday">Неділя</option>
                </select>
                
                <button type="submit">Зберегти графік</button>
            </form>
        </div>
    );
}
