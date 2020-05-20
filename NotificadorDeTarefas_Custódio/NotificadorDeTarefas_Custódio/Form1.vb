Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
        NotifyIcon1.BalloonTipText = "Notificador de Tarefas v1.0"
        NotifyIcon1.BalloonTipTitle = "Esta é uma mensagem de notificação."
        NotifyIcon1.ShowBalloonTip(2000)

        Dim l As New Login
        l.MdiParent = Me
        l.Show()

    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick

        MessageBox.Show("Aqui aparece a notificação da tarefa.")
        NotifyIcon1.Visible = False

    End Sub
End Class
